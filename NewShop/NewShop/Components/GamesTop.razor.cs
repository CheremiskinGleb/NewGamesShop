using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using NewShop.Data;
using NewShop.Model;
using Microsoft.JSInterop;
using NewShop.Service.CartHandler;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace NewShop.Components
{
	public class GamesTopCode : ComponentBase
	{
		[Inject]
		private ApplicationDbContext context { get; set; }
		[Inject]
		private IJSRuntime iJS { get; set; }
		[Inject]
		private ICartHandlerService cartService { get;set; }
		[Inject]
		private NavigationManager NavigationManager { get; set; }
		public List<Games> Games { get; set; }

        private List<int> cartGamesId = new List<int>();
		public string name { get; set; }
		protected override void OnInitialized()
		{
			Games = GetGamesTop();
            cartGamesId = cartService.GetCart();
			StateHasChanged();
		}

		public async void AddToCart(int gameId)
		{
			cartGamesId = await cartService.AddToCart(gameId);
		}

        public List<Games> GetGamesTop()
        {
            var topIds = GetTopGameIds();

            var games = (from g in context.Games
                         where topIds.Contains(g.Id)
                         select g
            ).ToList<Games>();

            return games;
        }

        public List<int> GetTopGameIds()
        {
            var topIds = new List<int>();

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            NpgsqlConnection connection = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
            NpgsqlCommand command = connection.CreateCommand();
            try
            {

                connection.Open();

                command.CommandText = @"SELECT r.""GameId"" FROM ""Reviews"" as r

INNER JOIN (
	SELECT ""GameId"", AVG(""Rating"") as ""avgRating"", COUNT(""Id"") as ""gameCount"" FROM ""Reviews""
	GROUP BY ""GameId""
) as ""gameRating"" ON r.""GameId"" = ""gameRating"".""GameId""

INNER JOIN (
	SELECT AVG(""Rating"") as ""allAvg"" FROM ""Reviews""
) as ""gamesAvg"" ON ""gamesAvg"".""allAvg"" IS NOT NULL
GROUP BY r.""GameId""
ORDER BY MAX((""gameRating"".""gameCount""/(""gameRating"".""gameCount"" + 5.0)) * ""gameRating"".""avgRating"" + (5.0 / (5.0 + ""gameRating"".""gameCount"")) * ""gamesAvg"".""allAvg"") DESC
LIMIT 4;";

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    topIds.Add(reader.GetInt32(0));
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return topIds;
        }

		public void GoTo(int gameId)
		{
			cartService.CloseCart();
			NavigationManager.NavigateTo("game/" + gameId);
		}
    }
}
