#pragma checksum "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoApp\NojomoApp\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc02a33d5234d2cf8a90305cae75b840bed2aff7"
// <auto-generated/>
#pragma warning disable 1591
namespace NojomoApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoApp\NojomoApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoApp\NojomoApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoApp\NojomoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoApp\NojomoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoApp\NojomoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoApp\NojomoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoApp\NojomoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoApp\NojomoApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoApp\NojomoApp\_Imports.razor"
using NojomoApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoApp\NojomoApp\_Imports.razor"
using NojomoApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoApp\NojomoApp\_Imports.razor"
using NojomoApp.Data.UserData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoApp\NojomoApp\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoApp\NojomoApp\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoApp\NojomoApp\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoApp\NojomoApp\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoApp\NojomoApp\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoApp\NojomoApp\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-bdgs2s7awz");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-bdgs2s7awz");
            __builder.OpenComponent<NojomoApp.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-bdgs2s7awz");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-bdgs2s7awz><a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-bdgs2s7awz>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-bdgs2s7awz");
            __builder.AddContent(15, 
#nullable restore
#line 14 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoApp\NojomoApp\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n");
            __builder.OpenComponent<Blazored.Modal.CascadingBlazoredModal>(17);
            __builder.AddAttribute(18, "Class", "modal modal-content");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
