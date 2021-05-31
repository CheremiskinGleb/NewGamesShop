using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewShop.Model;
using NewShop.Data;
using Microsoft.AspNetCore.Components.Authorization;

namespace NewShop.Components
{
    public class NewGameCode : ComponentBase
    {
        [Inject]
        public NavigationManager NM { get; set; }
        [Inject]
        public ApplicationDbContext Context { get; set; }
        [CascadingParameter]
        private Task<AuthenticationState> AuthenticationStateTask { get; set; }
        public string UserName { get; set; }
        public Games Game = new Games();
        public DateTime? date = DateTime.Today;

        protected override async Task OnInitializedAsync()
        {
            var authState = await AuthenticationStateTask;
            UserName = authState.User.Identity.Name;

            Game.Developer = UserName;
        }

        public void SaveGame()
        {
            if (Game.Name != "" && Game.Genre != null && Game.Developer != "" && Game.Description != "" && Game.Status != "")
            {
                Game.ReleaseDate = date.Value;
                try
                {
                    Context.Games.Add(Game);
                    Context.SaveChanges();
                    NM.NavigateTo("/library");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
