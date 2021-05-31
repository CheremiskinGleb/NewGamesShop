using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewShop.Data;
using NewShop.Model;
using Npgsql;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Components.Authorization;

namespace NewShop.Components
{
    public class UserLibraryCode : ComponentBase
    {
        [Inject]
        public ApplicationDbContext Context { get; set; }
        [Inject]
        public NavigationManager NM { get; set; }
        [CascadingParameter]
        private Task<AuthenticationState> AuthenticationStateTask { get; set; }

        protected List<Games> GamesList { get; set; } = new List<Games>();
        public string UserName { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var authState = await AuthenticationStateTask;
            UserName = authState.User.Identity.Name;

            if (authState.User.IsInRole("Customer"))
            {
                GamesList = (from game in Context.Games
                             join libr in Context.UserLibrary on game.Id equals libr.GameId
                             join user in Context.Users on libr.UserId equals user.Id
                             where user.UserName == UserName
                             select game).ToList<Games>();
            }
            else
            {
                GamesList = (from game in Context.Games
                             where game.Developer == UserName
                             select game).ToList<Games>();
            }

            await InvokeAsync(() => StateHasChanged());
        }
    }
}
