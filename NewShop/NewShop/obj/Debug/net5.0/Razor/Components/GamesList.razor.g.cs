#pragma checksum "C:\Users\Пользователь\Desktop\NewShop\NewShop\NewShop\Components\GamesList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6538736d236c8688a157b230e03190dc2ea2dd87"
// <auto-generated/>
#pragma warning disable 1591
namespace NewShop.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Пользователь\Desktop\NewShop\NewShop\NewShop\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Пользователь\Desktop\NewShop\NewShop\NewShop\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Пользователь\Desktop\NewShop\NewShop\NewShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Пользователь\Desktop\NewShop\NewShop\NewShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Пользователь\Desktop\NewShop\NewShop\NewShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Пользователь\Desktop\NewShop\NewShop\NewShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Пользователь\Desktop\NewShop\NewShop\NewShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Пользователь\Desktop\NewShop\NewShop\NewShop\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Пользователь\Desktop\NewShop\NewShop\NewShop\_Imports.razor"
using NewShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Пользователь\Desktop\NewShop\NewShop\NewShop\_Imports.razor"
using NewShop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Пользователь\Desktop\NewShop\NewShop\NewShop\Components\GamesList.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Пользователь\Desktop\NewShop\NewShop\NewShop\Components\GamesList.razor"
using NewShop.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/gameslist")]
    public partial class GamesList : GamesListCode
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudText>(0);
            __builder.AddAttribute(1, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 6 "C:\Users\Пользователь\Desktop\NewShop\NewShop\NewShop\Components\GamesList.razor"
                Color.Primary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 6 "C:\Users\Пользователь\Desktop\NewShop\NewShop\NewShop\Components\GamesList.razor"
                                     Typo.h3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "Игры");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenComponent<MudBlazor.MudPaper>(6);
            __builder.AddAttribute(7, "Style", "margin-top: 20px;");
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudGrid>(9);
                __builder2.AddAttribute(10, "Spacing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "C:\Users\Пользователь\Desktop\NewShop\NewShop\NewShop\Components\GamesList.razor"
                      4

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "Style", "padding: 10px;");
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 9 "C:\Users\Пользователь\Desktop\NewShop\NewShop\NewShop\Components\GamesList.razor"
         foreach (var game in Games)
		{

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<MudBlazor.MudItem>(13);
                    __builder3.AddAttribute(14, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "C:\Users\Пользователь\Desktop\NewShop\NewShop\NewShop\Components\GamesList.razor"
                     12

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "C:\Users\Пользователь\Desktop\NewShop\NewShop\NewShop\Components\GamesList.razor"
                             6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "C:\Users\Пользователь\Desktop\NewShop\NewShop\NewShop\Components\GamesList.razor"
                                    3

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Пользователь\Desktop\NewShop\NewShop\NewShop\Components\GamesList.razor"
                                                 () => GoTo(game.Id)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudPaper>(19);
                        __builder4.AddAttribute(20, "Style", "padding: 10px");
                        __builder4.AddAttribute(21, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "C:\Users\Пользователь\Desktop\NewShop\NewShop\NewShop\Components\GamesList.razor"
                                                       4

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(22, "Height", "320");
                        __builder4.AddAttribute(23, "Width", "240");
                        __builder4.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenElement(25, "div");
                            __builder5.AddAttribute(26, "class", "box");
                            __builder5.OpenElement(27, "img");
                            __builder5.AddAttribute(28, "src", 
#nullable restore
#line 14 "C:\Users\Пользователь\Desktop\NewShop\NewShop\NewShop\Components\GamesList.razor"
                                (game.Status != "" || game.Status != null) ? game.Status : "/default.jpg"

#line default
#line hidden
#nullable disable
                            );
                            __builder5.AddAttribute(29, "alt", 
#nullable restore
#line 14 "C:\Users\Пользователь\Desktop\NewShop\NewShop\NewShop\Components\GamesList.razor"
                                                                                                                  game.Name

#line default
#line hidden
#nullable disable
                            );
                            __builder5.AddAttribute(30, "title", 
#nullable restore
#line 14 "C:\Users\Пользователь\Desktop\NewShop\NewShop\NewShop\Components\GamesList.razor"
                                                                                                                                     game.Name

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                            __builder5.AddMarkupContent(31, "\r\n\t\t\t\t\t");
                            __builder5.OpenElement(32, "h1");
                            __builder5.AddContent(33, 
#nullable restore
#line 15 "C:\Users\Пользователь\Desktop\NewShop\NewShop\NewShop\Components\GamesList.razor"
                         game.Name

#line default
#line hidden
#nullable disable
                            );
                            __builder5.CloseElement();
                            __builder5.CloseElement();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 24 "C:\Users\Пользователь\Desktop\NewShop\NewShop\NewShop\Components\GamesList.razor"
		}

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
