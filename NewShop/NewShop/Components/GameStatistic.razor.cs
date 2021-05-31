using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using Microsoft.Extensions.Configuration;

namespace NewShop.Components
{
    public class GameStatisticCode : ComponentBase
    {

        [Parameter]
        public int GameId { get; set; } = 0;

        public bool Downloading { get; set; } = true;
        public string AvgRating { get; set; } = "Нет";
        public string ReviewCount { get; set; } = "Нет";

        protected override async Task OnInitializedAsync()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            NpgsqlConnection connection = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
            NpgsqlCommand command = connection.CreateCommand();
            command.CommandText = @"SELECT count(*), avg(""Rating"") FROM ""Reviews"" WHERE ""GameId"" = " + GameId;

            if (GameId != 0)
            {
                try 
                {
                    connection.Open();
                    var reader = await command.ExecuteReaderAsync();
                    while (reader.Read())
                    {
                        ReviewCount = reader.GetInt32(0).ToString();
                        AvgRating = String.Format("{0:N2}", reader.GetDouble(1));//reader.GetDouble(1).ToString();
                    }
                }
                catch(Exception e) 
                {
                    Console.WriteLine(e.Message);
                }
                finally 
                {
                    connection.Close();
                    Downloading = false;
                    await InvokeAsync(() => StateHasChanged());
                }
            }
        }
    }
}
