#pragma checksum "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e75ef9657d8086535dc6c659ad6f5ff0c5b7bfb5"
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
#line 1 "D:\F\NewGamesShop\NewShop\NewShop\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\F\NewGamesShop\NewShop\NewShop\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\F\NewGamesShop\NewShop\NewShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\F\NewGamesShop\NewShop\NewShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\F\NewGamesShop\NewShop\NewShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\F\NewGamesShop\NewShop\NewShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\F\NewGamesShop\NewShop\NewShop\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\F\NewGamesShop\NewShop\NewShop\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\F\NewGamesShop\NewShop\NewShop\_Imports.razor"
using NewShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\F\NewGamesShop\NewShop\NewShop\_Imports.razor"
using NewShop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\F\NewGamesShop\NewShop\NewShop\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
           [Authorize(Roles = "Customer, Developer")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/library")]
    public partial class UserLibrary : UserLibraryCode
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Roles", "Customer");
            __builder.AddAttribute(2, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudText>(3);
                __builder2.AddAttribute(4, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 8 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                    Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 8 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                         Typo.h3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(7, "Библиотека");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\r\n\t\t");
                __builder2.OpenComponent<global::MudBlazor.MudPaper>(9);
                __builder2.AddAttribute(10, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 11 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
             if (GamesList.Count > 0)
			{

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<global::MudBlazor.MudList>(11);
                    __builder3.AddAttribute(12, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 14 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                     foreach (var game in GamesList)
					{

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<global::MudBlazor.MudListItem>(13);
                        __builder4.AddAttribute(14, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                 () => NM.NavigateTo("/game/" + game.Id)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(15, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<global::MudBlazor.MudGrid>(16);
                            __builder5.AddAttribute(17, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<global::MudBlazor.MudItem>(18);
                                __builder6.AddAttribute(19, "xs", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 18 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                             12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(20, "sm", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 18 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                     4

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(21, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenElement(22, "div");
                                    __builder7.AddAttribute(23, "class", "box");
                                    __builder7.AddAttribute(24, "style", "height: 400px");
                                    __builder7.OpenElement(25, "img");
                                    __builder7.AddAttribute(26, "height", "400");
                                    __builder7.AddAttribute(27, "src", 
#nullable restore
#line 20 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                                 (game.Status != "" || game.Status != null) ? game.Status : "/default.jpg"

#line default
#line hidden
#nullable disable
                                    );
                                    __builder7.AddAttribute(28, "alt", 
#nullable restore
#line 20 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                                                                                                                   game.Name

#line default
#line hidden
#nullable disable
                                    );
                                    __builder7.AddAttribute(29, "title", 
#nullable restore
#line 20 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                                                                                                                                      game.Name

#line default
#line hidden
#nullable disable
                                    );
                                    __builder7.CloseElement();
                                    __builder7.CloseElement();
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(30, "\r\n\t\t\t\t\t\t\t\t");
                                __builder6.OpenComponent<global::MudBlazor.MudItem>(31);
                                __builder6.AddAttribute(32, "xs", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 23 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                             12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(33, "sm", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 23 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                     8

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(34, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<global::MudBlazor.MudText>(35);
                                    __builder7.AddAttribute(36, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 24 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                    Color.Tertiary

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(37, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 24 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                                          Typo.h4

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(38, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
#nullable restore
#line 24 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
__builder8.AddContent(39, game.Name);

#line default
#line hidden
#nullable disable
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(40, "\r\n\t\t\t\t\t\t\t\t\t");
                                    __builder7.OpenComponent<global::MudBlazor.MudText>(41);
                                    __builder7.AddAttribute(42, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 25 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                    Color.Tertiary

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(43, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 25 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                                          Typo.h5

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(44, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
#nullable restore
#line 25 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
__builder8.AddContent(45, game.Developer);

#line default
#line hidden
#nullable disable
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(46, "\r\n\t\t\t\t\t\t\t\t\t");
                                    __builder7.OpenComponent<global::MudBlazor.MudText>(47);
                                    __builder7.AddAttribute(48, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 26 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                    Color.Tertiary

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(49, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 26 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                                          Typo.h5

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(50, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
#nullable restore
#line 26 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
__builder8.AddContent(51, game.Genre);

#line default
#line hidden
#nullable disable
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(52, "\r\n\t\t\t\t\t\t\t\t\t");
                                    __builder7.OpenComponent<global::MudBlazor.MudText>(53);
                                    __builder7.AddAttribute(54, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 27 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                    Color.Tertiary

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(55, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 27 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                                          Typo.body2

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(56, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
#nullable restore
#line 27 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
__builder8.AddContent(57, game.ReleaseDate.ToShortDateString());

#line default
#line hidden
#nullable disable
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(58, "\r\n\t\t\t\t\t\t\t\t\t");
                                    __builder7.OpenComponent<global::MudBlazor.MudText>(59);
                                    __builder7.AddAttribute(60, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 28 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                    Color.Tertiary

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(61, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 28 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                                          Typo.body1

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(62, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
#nullable restore
#line 28 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
__builder8.AddContent(63, game.Description);

#line default
#line hidden
#nullable disable
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(64, "\r\n\t\t\t\t\t\t\t\t\t");
                                    __builder7.OpenComponent<global::MudBlazor.MudText>(65);
                                    __builder7.AddAttribute(66, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 29 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                    Color.Tertiary

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(67, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 29 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                                          Typo.body1

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(68, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
#nullable restore
#line 29 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
__builder8.AddContent(69, game.Price);

#line default
#line hidden
#nullable disable
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(70, "\r\n\t\t\t\t\t\t");
                        __builder4.OpenComponent<global::MudBlazor.MudDivider>(71);
                        __builder4.CloseComponent();
#nullable restore
#line 34 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
					}

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 36 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
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
            __builder.AddMarkupContent(72, "\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(73);
            __builder.AddAttribute(74, "Roles", "Developer");
            __builder.AddAttribute(75, "Authorized", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudText>(76);
                __builder2.AddAttribute(77, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 42 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                        Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 42 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                             Typo.h3

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(79, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(80, "Библиотека игр ");
#nullable restore
#line 42 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
__builder3.AddContent(81, UserName);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(82, "\r\n\t\t");
                __builder2.OpenComponent<global::MudBlazor.MudButton>(83);
                __builder2.AddAttribute(84, "Style", "margin: 20px;");
                __builder2.AddAttribute(85, "Variant", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Variant>(
#nullable restore
#line 43 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                  Variant.Filled

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 43 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                                         Color.Tertiary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                                                                    () => NM.NavigateTo("/newgame")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(88, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(89, "Новая игра");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(90, "\r\n\t\t");
                __builder2.OpenComponent<global::MudBlazor.MudPaper>(91);
                __builder2.AddAttribute(92, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 45 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
             if (GamesList.Count > 0)
			{

#line default
#line hidden
#nullable disable
                    __builder3.OpenComponent<global::MudBlazor.MudList>(93);
                    __builder3.AddAttribute(94, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 48 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                     foreach (var game in GamesList)
					{

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<global::MudBlazor.MudListItem>(95);
                        __builder4.AddAttribute(96, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                 () => NM.NavigateTo("/game/" + game.Id)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(97, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<global::MudBlazor.MudGrid>(98);
                            __builder5.AddAttribute(99, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<global::MudBlazor.MudItem>(100);
                                __builder6.AddAttribute(101, "xs", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 52 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                             12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(102, "sm", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 52 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                     4

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(103, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenElement(104, "div");
                                    __builder7.AddAttribute(105, "class", "box");
                                    __builder7.AddAttribute(106, "style", "height: 400px");
                                    __builder7.OpenElement(107, "img");
                                    __builder7.AddAttribute(108, "height", "400");
                                    __builder7.AddAttribute(109, "src", 
#nullable restore
#line 54 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                                 (game.Status != "" || game.Status != null) ? game.Status : "/default.jpg"

#line default
#line hidden
#nullable disable
                                    );
                                    __builder7.AddAttribute(110, "alt", 
#nullable restore
#line 54 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                                                                                                                   game.Name

#line default
#line hidden
#nullable disable
                                    );
                                    __builder7.AddAttribute(111, "title", 
#nullable restore
#line 54 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                                                                                                                                      game.Name

#line default
#line hidden
#nullable disable
                                    );
                                    __builder7.CloseElement();
                                    __builder7.CloseElement();
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(112, "\r\n\t\t\t\t\t\t\t\t");
                                __builder6.OpenComponent<global::MudBlazor.MudItem>(113);
                                __builder6.AddAttribute(114, "xs", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 57 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                             12

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(115, "sm", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 57 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                     8

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddAttribute(116, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.OpenComponent<global::MudBlazor.MudText>(117);
                                    __builder7.AddAttribute(118, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 58 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                    Color.Tertiary

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(119, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 58 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                                          Typo.h4

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(120, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
#nullable restore
#line 58 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
__builder8.AddContent(121, game.Name);

#line default
#line hidden
#nullable disable
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(122, "\r\n\t\t\t\t\t\t\t\t\t");
                                    __builder7.OpenComponent<global::MudBlazor.MudText>(123);
                                    __builder7.AddAttribute(124, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 59 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                    Color.Tertiary

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(125, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 59 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                                          Typo.h5

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(126, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
#nullable restore
#line 59 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
__builder8.AddContent(127, game.Genre);

#line default
#line hidden
#nullable disable
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(128, "\r\n\t\t\t\t\t\t\t\t\t");
                                    __builder7.OpenComponent<global::MudBlazor.MudText>(129);
                                    __builder7.AddAttribute(130, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 60 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                    Color.Tertiary

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(131, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 60 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                                          Typo.body2

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(132, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
#nullable restore
#line 60 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
__builder8.AddContent(133, game.ReleaseDate.ToShortDateString());

#line default
#line hidden
#nullable disable
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(134, "\r\n\t\t\t\t\t\t\t\t\t");
                                    __builder7.OpenComponent<global::MudBlazor.MudText>(135);
                                    __builder7.AddAttribute(136, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 61 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                    Color.Tertiary

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(137, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 61 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                                          Typo.body1

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(138, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
#nullable restore
#line 61 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
__builder8.AddContent(139, game.Description);

#line default
#line hidden
#nullable disable
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(140, "\r\n\t\t\t\t\t\t\t\t\t");
                                    __builder7.OpenComponent<global::MudBlazor.MudText>(141);
                                    __builder7.AddAttribute(142, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 62 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                    Color.Tertiary

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(143, "Typo", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Typo>(
#nullable restore
#line 62 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
                                                                          Typo.body1

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(144, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
#nullable restore
#line 62 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
__builder8.AddContent(145, game.Price);

#line default
#line hidden
#nullable disable
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(146, "\r\n\t\t\t\t\t\t");
                        __builder4.OpenComponent<global::MudBlazor.MudDivider>(147);
                        __builder4.CloseComponent();
#nullable restore
#line 67 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
					}

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
#nullable restore
#line 69 "D:\F\NewGamesShop\NewShop\NewShop\Components\UserLibrary.razor"
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NM { get; set; }
    }
}
#pragma warning restore 1591
