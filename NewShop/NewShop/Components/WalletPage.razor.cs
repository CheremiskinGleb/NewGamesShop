using Microsoft.AspNetCore.Components;
using System.Net.NetworkInformation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql;
using NewShop.Data;
using System.Linq;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Components.Authorization;

namespace NewShop.Components
{
    public partial class WalletPage : ComponentBase
    {
        [Inject]
        public ApplicationDbContext DbContext { get; set; }
        [CascadingParameter]
        private Task<AuthenticationState> AuthenticationStateTask { get; set; }
        private string UserName { get; set; } = "";
        private string UserId { get; set; } = "";
        public int Wallet { get; set; } = -1;
        public int Amount { get; set; } = 0;

        protected override async Task OnInitializedAsync()
        {
            var authState = await AuthenticationStateTask;
            UserName = authState.User.Identity.Name;

            UserId = (from user in DbContext.Users
                      where user.UserName == UserName
                      select user.Id).First();


            LoadUserWallet();
        }

        private async void LoadUserWallet()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            NpgsqlConnection connection = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
            NpgsqlCommand command = connection.CreateCommand();
            try
            {

                connection.Open();

                var query = @"SELECT ""Wallet"" FROM ""AspNetUsers"" WHERE ""Id"" = '" + UserId + "' limit 1";

                Console.WriteLine(query);

                command.CommandText = query;

                var result = await command.ExecuteScalarAsync();

                if (result is null)
                {
                    Console.WriteLine("No result!");
                    return;
                }

                Wallet = (int)result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                await InvokeAsync(() => StateHasChanged());
            }
        }

        public async void Demount() 
        {
            if (Amount <= 0)
            {
                return;
            }

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            NpgsqlConnection connection = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
            NpgsqlCommand command = connection.CreateCommand();
            try
            {

                connection.Open();

                var query = $@"UPDATE ""AspNetUsers"" SET ""Wallet"" = '{Wallet + Amount}' WHERE ""Id"" = '" + UserId + "'";

                Console.WriteLine(query);

                command.CommandText = query;

                var result = await command.ExecuteScalarAsync();

                if (result is null)
                {
                    Console.WriteLine("No result!");
                    return;
                }

                Wallet = (int)result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                LoadUserWallet();
            }
        }
    }
}
