#pragma checksum "D:\F\NewGamesShop\NewShop\NewShop\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b1ef64ee23476a74d53081aa24928e6f73507fc"
// <auto-generated/>
#pragma warning disable 1591
namespace NewShop
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
    public partial class App : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(0);
            __builder.AddAttribute(1, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudThemeProvider>(2);
                __builder2.AddAttribute(3, "Theme", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.MudTheme>(
#nullable restore
#line 2 "D:\F\NewGamesShop\NewShop\NewShop\App.razor"
                             MyTheme

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(4, "\r\n\t");
                __builder2.OpenComponent<global::MudBlazor.MudDialogProvider>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n\t");
                __builder2.OpenComponent<global::MudBlazor.MudSnackbarProvider>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\t");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.Router>(9);
                __builder2.AddAttribute(10, "AppAssembly", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Reflection.Assembly>(
#nullable restore
#line 5 "D:\F\NewGamesShop\NewShop\NewShop\App.razor"
                          typeof(Program).Assembly

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "PreferExactMatches", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 5 "D:\F\NewGamesShop\NewShop\NewShop\App.razor"
                                                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "Found", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder3) => {
                    __builder3.OpenComponent<global::Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(13);
                    __builder3.AddAttribute(14, "RouteData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 7 "D:\F\NewGamesShop\NewShop\NewShop\App.razor"
                                            routeData

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(15, "DefaultLayout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Type>(
#nullable restore
#line 7 "D:\F\NewGamesShop\NewShop\NewShop\App.razor"
                                                                       typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(16, "NotFound", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<global::Microsoft.AspNetCore.Components.LayoutView>(17);
                    __builder3.AddAttribute(18, "Layout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Type>(
#nullable restore
#line 10 "D:\F\NewGamesShop\NewShop\NewShop\App.razor"
                                 typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(20, "<p>Sorry, there\'s nothing at this address.</p>");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "D:\F\NewGamesShop\NewShop\NewShop\App.razor"
      
	MudTheme MyTheme = new MudTheme()
	{
		Palette = new Palette()
		{
			Primary = Colors.Purple.Default,
			Secondary = Colors.Grey.Darken1,
			AppbarBackground = Colors.Grey.Darken3,
			Tertiary = Colors.Grey.Darken4,
			Background = Colors.Grey.Darken3,
			TextPrimary = Colors.Shades.Black,
			DrawerBackground = Colors.Grey.Darken1,
			TextSecondary = Colors.Grey.Darken2,
			BackgroundGrey = Colors.Grey.Darken2
		},

		LayoutProperties = new LayoutProperties()
		{
			DrawerWidthLeft = "260px",
			DrawerWidthRight = "300px"
		}
	};

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
