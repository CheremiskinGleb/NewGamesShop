using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewShop.Model;
using NewShop.Service.CartHandler;
using NewShop.Data;

namespace NewShop.Components
{
    public class CartCode : ComponentBase
    {
        [Inject]
        public ICartHandlerService CartService { get; set; }
        [Inject]
        public ApplicationDbContext Context { get; set; }
        public List<Games> GamesList { get; set; } = new List<Games>();

        public int Summary = 0;

        public void RemoveFromCart(Games game)
        {
            GamesList.Remove(game);
            CartService.RemoveFromCart(game.Id);

            CountSummary();
        }

        protected override void OnInitialized()
        {
            if (CartService.Loaded)
                LoadCart();
            CartService.CartLoadEvent += () => LoadCart();
        }

        private async void LoadCart()
        {
            GamesList.Clear();
            var gamesIds = CartService.GetCart();
            foreach (var gameId in gamesIds)
            {
                var game = await Context.Games.FindAsync(gameId);
                if (game != null) GamesList.Add(game);
            }

            CountSummary();

            await InvokeAsync(() => StateHasChanged());
        }

        private void CountSummary()
        {
            var sum = 0;

            foreach (var game in GamesList)
            {
                sum += game.Price;
            }

            Summary =  sum;
        }
    }
}
