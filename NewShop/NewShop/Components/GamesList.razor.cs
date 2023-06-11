using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using NewShop.Data;
using NewShop.Model;
using Microsoft.JSInterop;
using NewShop.Service.CartHandler;

namespace NewShop.Components
{
	public class GamesListCode : ComponentBase
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
        public List<Games> FiltiredGames { get; set; }
        private List<int> cartGamesId = new List<int>();
		public string name { get; set; }
		protected override void OnInitialized()
		{
			Games = context.Games.ToList<Games>();
            FiltiredGames = Games;
            cartGamesId = cartService.GetCart();
			StateHasChanged();
		}

		public async void AddToCart(int gameId)
		{
			cartGamesId = await cartService.AddToCart(gameId);
		}

		public void GoTo(int gameId)
		{
			cartService.CloseCart();
			NavigationManager.NavigateTo("game/" + gameId);
		}
        public void Filter()
        {
            FiltiredGames = string.IsNullOrEmpty(name)? Games 
				: Games.Where(g => g.Name.ToUpper().Contains(name.ToUpper()) || g.Genre.ToUpper().Contains(name.ToUpper()))
				.ToList<Games>();
            StateHasChanged();
        }
    }
}
