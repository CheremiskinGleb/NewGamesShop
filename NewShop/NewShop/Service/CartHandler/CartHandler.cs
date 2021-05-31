using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.JSInterop;

namespace NewShop.Service.CartHandler
{
    public class CartHandler : ICartHandlerService
    {
        public delegate void CartLoadHandler();
        public event CartLoadHandler CartLoadEvent;
        public event CartLoadHandler CartCloseEvent;
        private IJSRuntime jsRuntime { get; set; }
        public List<int> games = new List<int>();
        public bool Loaded { get; private set; } = false;
        public CartHandler(IJSRuntime jsr)
        {
            jsRuntime = jsr;
            LoadCartAsync();
        }

        public List<int> GetCart()
        {
            return games;
        }

        public async Task LoadCartAsync()
        {
            string cartStr = String.Empty;
            cartStr = await jsRuntime.InvokeAsync<string>("get", "cart");
            dynamic cart = JsonConvert.DeserializeObject<dynamic>(cartStr);
            foreach (var gameId in cart)
            {
                games.Add(Convert.ToInt32(gameId));
            }
            CartLoadEvent?.Invoke();
            Loaded = true;
        }

        public async Task SetCartAsync()
        {
            var data = JsonConvert.SerializeObject(games);
            await jsRuntime.InvokeVoidAsync("set", "cart", data);
        }

        public async Task<List<int>> AddToCart(int gameId)
        {
            if (!games.Exists(x => x == gameId))
            {
                games.Add(gameId);
            }
            await SetCartAsync();
            CartLoadEvent?.Invoke();
            return games;
        }

        public async void RemoveFromCart(int gameId)
        {
            games.Remove(gameId);
            await SetCartAsync();
            CartLoadEvent?.Invoke();
        }

        public async void ClearCart()
        {
            games.Clear();
            await SetCartAsync();
            CartLoadEvent?.Invoke();
        }
        public void CloseCart()
        {
            CartCloseEvent?.Invoke();
        }
    }

    public interface ICartHandlerService
    {
        public bool Loaded { get; }
        public Task LoadCartAsync();
        public Task SetCartAsync();
        public List<int> GetCart();
        public Task<List<int>> AddToCart(int gameId);
        public void RemoveFromCart(int gameId);
        public void ClearCart();
        public void CloseCart();
        event CartHandler.CartLoadHandler CartLoadEvent;
        event CartHandler.CartLoadHandler CartCloseEvent;
    }

}
