// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace NojomoApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\_Imports.razor"
using NojomoApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\_Imports.razor"
using NojomoApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\_Imports.razor"
using NojomoApp.Data.UserData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    public partial class Validations : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Shared\Validations.razor"
           
        [Parameter]
        public bool IsVisible { get; set; }
        [Parameter]
        public RenderFragment ChildContent { get; set; }
        [Parameter]
        public bool Result { get; set; }

        private void Close()
        {
            IsVisible = false;
        }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
