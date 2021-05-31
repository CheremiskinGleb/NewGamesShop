using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewShop.Data;
using NewShop.Model;
using NewShop.Service.CartHandler;
using Microsoft.AspNetCore.Components.Authorization;

namespace NewShop.Components
{
    public class GamePageCode: ComponentBase
    {
        [Inject]
        public NavigationManager NM { get; set; }
        [Inject]
        public ApplicationDbContext Context { get; set; }
        [Inject]
        public ICartHandlerService CartService { get; set; }
        [CascadingParameter]
        private Task<AuthenticationState> AuthenticationStateTask { get; set; }

        [Parameter]
        public int GameId { get; set; }
        private string UserId { get; set; }
        public string UserName { get; set; }
        public Games Game { get; set; }
        public DateTime? date = DateTime.Today;
        public List<Reviews> ReviewsList { get; set; } = new List<Reviews>();
        public string NewReviewText { get; set; } = "";
        public int NewReviewRating { get; set; } = 5;
        protected bool GamePurchased { get; set; } = false;

        protected override async Task OnInitializedAsync()
        {
            var authState = await AuthenticationStateTask;
            UserName = authState.User.Identity.Name;

            try
            {
                UserId = (from user in Context.Users
                          where user.UserName == UserName
                          select user.Id).First();
            }
            catch
            {
                UserId = "";
            }

            try
            {
                Game = Context.Games.Find(GameId);
                if (Game != null)
                {
                    date = Game.ReleaseDate;
                    ReviewsList = (from rev in Context.Reviews
                                   where rev.GameId == GameId
                                   select rev).ToList<Reviews>();
                }
            }
            catch
            {
                Game = null;
            }

            if ((from libr in Context.UserLibrary
                where libr.UserId == UserId && libr.GameId == GameId
                select libr).Count() > 0)
                GamePurchased = true;

            await InvokeAsync(() => StateHasChanged());
        }

        public void AddToCart()
        {
            CartService.AddToCart(GameId);
        }

        public void NewReview()
        {
            if (NewReviewText != "" && UserId != "")
            {
                Reviews review = new Reviews()
                {
                    Comment = NewReviewText,
                    Rating = Convert.ToDouble(NewReviewRating),
                    UserId = UserId,
                    GameId = GameId
                };
                Context.Reviews.Add(review);
                Context.SaveChanges();
                ReviewsList.Add(review);
                StateHasChanged();
            }
        }

        public void SaveGame()
        {
            if (Game.Name != "" && Game.Genre != null && Game.Developer != "" && Game.Description != "")
            {
                Game.ReleaseDate = date.Value;
                try
                {
                    Context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
