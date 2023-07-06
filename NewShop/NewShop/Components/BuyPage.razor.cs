using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewShop.Service.CartHandler;
using NewShop.Model;
using NewShop.Data;
using Npgsql;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Components.Authorization;
using System.ComponentModel.DataAnnotations;

namespace NewShop.Components
{
    public class BuyPageCode : ComponentBase
    {
        [Inject]
        public ICartHandlerService CartHandler { get; set; }
        [Inject]
        public ApplicationDbContext DbContext { get; set; }
        [Inject]
        public NavigationManager NM { get; set; }
        [CascadingParameter]
        private Task<AuthenticationState> AuthenticationStateTask { get; set; }
        public List<Games> GamesList { get; set; } = new List<Games>();

        public int Summary = 0;
        public bool Loading { get; set; } = true;
        private string UserName { get; set; } = "";
        private string UserId { get; set; } = "";
        public int Wallet { get; set; } = -1;

        protected override void OnInitialized()
        {

            GamesList = new List<Games>();
            LoadCart();
            CartHandler.CartLoadEvent += () => LoadCart();
        }

        protected override async Task OnInitializedAsync()
        {
            var authState = await AuthenticationStateTask;
            UserName = authState.User.Identity.Name;

            UserId = (from user in DbContext.Users
                      where user.UserName == UserName
                      select user.Id).First();


            LoadUserWallet();
        }

        private void LoadCart()
        {
            Loading = true;
            GamesList.Clear();
            var gamesIds = CartHandler.GetCart();
            foreach (var gameId in gamesIds)
            {
                var game = DbContext.Games.Find(gameId);
                if (game != null) GamesList.Add(game);
            }
            Loading = false;
            CountSummary();
            StateHasChanged();
        }

        public void RemoveFromCart(Games game)
        {
            CartHandler.RemoveFromCart(game.Id);
            CountSummary();
        }

        public void BuyGames()
        {
            if (GamesList.Count > 0 && UserId != "")
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
                    foreach (var game in GamesList)
                    {
                        command.CommandText = $@"BEGIN;UPDATE ""AspNetUsers"" SET ""Wallet"" = '{Wallet - game.Price}' WHERE ""Id"" = '{UserId}';" +
                            @"INSERT INTO ""UserLibrary""(""UserId"", ""GameId"") " +
                            @"VALUES ('" + UserId + "', '" + game.Id + "');" +
                            $@"UPDATE ""AspNetUsers"" SET ""Wallet"" = '{(int)(game.Price * 0.9)}' WHERE ""UserName"" = (" + 
                            $@"SELECT ""Developer"" FROM ""Games"" WHERE ""Id"" = '{game.Id}' " + 
                            ");"+
                            "END;";

                        command.ExecuteNonQuery();
                    }

                    CartHandler.ClearCart();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                    CartHandler.CloseCart();
                    NM.NavigateTo("/");
                }
            }
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
                connection.Close();
                await InvokeAsync(() => StateHasChanged());
            }
        }

        public void ToWallet()
        {
            NM.NavigateTo("/wallet");
        }

        private void CountSummary()
        {
            var sum = 0;

            foreach (var game in GamesList)
            {
                sum += game.Price;
            }

            Summary = sum;
        }
    }
}

