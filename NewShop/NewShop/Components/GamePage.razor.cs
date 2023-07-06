using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewShop.Data;
using NewShop.Model;
using NewShop.Service.CartHandler;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.JSInterop;

namespace NewShop.Components
{
    public class GamePageCode : ComponentBase
    {
        [Inject]
        public IConfiguration config { get; set; }

        [Inject]
        public IJSRuntime jsRuntime { get; set; }
        
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

        public void SaveGame(bool setReleaseDate = true)
        {
            if (Game.Name != "" && Game.Genre != null && Game.Developer != "" && Game.Description != "")
            {

                if (setReleaseDate)
                {
                    Game.ReleaseDate = date.Value;
                }

                try
                {
                    Context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    StateHasChanged();
                }
            }
        }

        public async Task LoadFile(Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs e)
        {
            try
            {
                var maxFileSize = 1024 * 1024 * 1024;
                
                var newFileName = Path.ChangeExtension(
                    Path.GetFileNameWithoutExtension(e.File.Name) + $"AA{GameId}AA" + DateTime.Now.Millisecond.ToString(),
                    Path.GetExtension(e.File.Name)
                );

                var path = Path.Combine(config.GetValue<string>("FileStorage"), "gameshop", newFileName);
                Directory.CreateDirectory(Path.Combine(config.GetValue<string>("FileStorage")!, "gameshop"));

                await using FileStream fs = new(path, FileMode.Create);
                await e.File.OpenReadStream(maxFileSize).CopyToAsync(fs);

                Game.File = newFileName;
                SaveGame(false);
            }
            catch
            {

            }
        }

        public async Task DownloadGame()
        {
            var fileName = Path.GetFileNameWithoutExtension(Game.File);
            var extention = Path.GetExtension(Game.File);

            await jsRuntime.InvokeVoidAsync("open", $"/api/Download/DownloadFile?fileName={fileName}&extention={extention.Remove(0, 1)}", "_blank");
        }
    }
}
