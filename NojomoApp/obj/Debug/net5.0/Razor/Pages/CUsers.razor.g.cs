#pragma checksum "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66511f71a3db314316c9869b89f5d0d7dbd700f3"
// <auto-generated/>
#pragma warning disable 1591
namespace NojomoApp.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/usuarios")]
    public partial class CUsers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Usuarios</h3>\r\n<br>\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                  ShowModalAdd

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "class", "btn btn-primary");
            __builder.AddContent(4, "Alta");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n<br>\r\n<br>");
#nullable restore
#line 13 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
 if (objMain == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p><em>Loading...</em></p>");
#nullable restore
#line 16 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-12");
            __builder.OpenComponent<Radzen.Blazor.RadzenFieldset>(9);
            __builder.AddAttribute(10, "Text", "Usuarios");
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "row");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<UserDto>>(14);
                __builder2.AddAttribute(15, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "AllowPaging", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                                                                true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 22 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                                                                                5

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 22 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                                                                                                 true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "EditMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.DataGridEditMode>(
#nullable restore
#line 22 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                                                                                                                 DataGridEditMode.Single

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "FilterCaseSensitivity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterCaseSensitivity>(
#nullable restore
#line 23 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                                   FilterCaseSensitivity.CaseInsensitive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<UserDto>>(
#nullable restore
#line 24 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                   objMain

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "FilterMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 24 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                                                        FilterMode.Advanced

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ColumnWidth", "120px");
                __builder2.AddAttribute(24, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<UserDto>>(25);
                    __builder3.AddAttribute(26, "Title", "Selección");
                    __builder3.AddAttribute(27, "Bubble", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                                                                                   false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(28, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                                                                                                      false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                                                                                                                       false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 27 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                                                                                                                                         TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(31, "Width", "100px");
                    __builder3.AddAttribute(32, "Template", (Microsoft.AspNetCore.Components.RenderFragment<UserDto>)((user) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenCheckBox<Boolean>>(33);
                        __builder4.AddAttribute(34, "id", "checkall");
                        __builder4.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Boolean>(
#nullable restore
#line 29 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                                                                            user.Check

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Check = __value, user.Check))));
                        __builder4.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<Boolean>>>(() => user.Check));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<UserDto>>(39);
                    __builder3.AddAttribute(40, "Property", "Alias");
                    __builder3.AddAttribute(41, "Title", "Alias");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, "\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<UserDto>>(43);
                    __builder3.AddAttribute(44, "Property", "Nombre");
                    __builder3.AddAttribute(45, "Title", "Nombre");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(46, "\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<UserDto>>(47);
                    __builder3.AddAttribute(48, "Property", "Tipo");
                    __builder3.AddAttribute(49, "Title", "Tipo");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<UserDto>>(51);
                    __builder3.AddAttribute(52, "Property", "Email");
                    __builder3.AddAttribute(53, "Title", "Email");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(54, "\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<UserDto>>(55);
                    __builder3.AddAttribute(56, "Property", "Telefono");
                    __builder3.AddAttribute(57, "Title", "Telefono");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, "\r\n\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<UserDto>>(59);
                    __builder3.AddAttribute(60, "Bubble", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                                                                 false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(61, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                                                                                    false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(62, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                                                                                                     false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(63, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 41 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                                                                                                                       TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(64, "Width", "70px");
                    __builder3.AddAttribute(65, "Template", (Microsoft.AspNetCore.Components.RenderFragment<UserDto>)((user) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(66);
                        __builder4.AddAttribute(67, "Icon", "edit");
                        __builder4.AddAttribute(68, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#nullable restore
#line 43 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                                                ButtonSize.Small

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(69, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                                                                           args => EditRow(user)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(70, "\r\n\r\n                        ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<UserDto>>(71);
                    __builder3.AddAttribute(72, "Bubble", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 48 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                                                                 false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(73, "Filterable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 48 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                                                                                    false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(74, "Sortable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 48 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                                                                                                     false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(75, "TextAlign", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 48 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                                                                                                                       TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(76, "Width", "70px");
                    __builder3.AddAttribute(77, "Template", (Microsoft.AspNetCore.Components.RenderFragment<UserDto>)((user) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(78);
                        __builder4.AddAttribute(79, "ButtonStyle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 50 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                                           ButtonStyle.Danger

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(80, "Icon", "close");
                        __builder4.AddAttribute(81, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#nullable restore
#line 50 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                                                                                  ButtonSize.Small

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(82, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                                                                                                             args => DeleteRow(user)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddComponentReferenceCapture(83, (__value) => {
#nullable restore
#line 22 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                  usersGrid = (Radzen.Blazor.RadzenGrid<UserDto>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(84, "\r\n\r\n        <br>\r\n        <br>\r\n        ");
            __builder.OpenElement(85, "button");
            __builder.AddAttribute(86, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                          deleteMultiple

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(87, "class", "btn btn-primary");
            __builder.AddMarkupContent(88, "Borrar selección");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenComponent<NojomoApp.Shared.Confirm>(89);
            __builder.AddAttribute(90, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 66 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                                            ConfirmDelete_Click

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(91, "ConfirmationMessage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 67 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                   $"¿Estás seguro de querer borrar a \"{userDelete.Nombre}\"?"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(92, (__value) => {
#nullable restore
#line 66 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                   DeleteConfirmation = (NojomoApp.Shared.Confirm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.OpenComponent<NojomoApp.Shared.Confirm>(93);
            __builder.AddAttribute(94, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 70 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                                                    ConfirmDeleteMultiple_Click

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(95, "ConfirmationMessage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 71 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                                   $"¿Estas seguro de querer borrar a todos los usuarios seleccionados?"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(96, (__value) => {
#nullable restore
#line 70 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
                   DeleteConfirmationMultiple = (NojomoApp.Shared.Confirm)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
#nullable restore
#line 73 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\CUsers.razor"
       
    RadzenGrid<UserDto> usersGrid;
    public UserDto user { get; set; }
    public UserDto userDelete { get; set; }

    private IEnumerable<UserDto> objMain;

    protected override async Task OnInitializedAsync()
    {
        base.OnInitialized();
        user = new UserDto();
        userDelete = new UserDto();
        await reload();

    }

    protected async Task reload()
    {
        objMain = await UserService.GetUserServiceAsync();

    }

    private void deleteMultiple()
    {
        DeleteConfirmationMultiple.Show();
    }

    void DeleteRow(UserDto user)
    {
        userDelete = user;
        DeleteConfirmation.Show();
    }

    protected Data.ConfirmBase DeleteConfirmation { get; set; }
    protected Data.ConfirmBase DeleteConfirmationMultiple { get; set; }

    protected async Task ConfirmDelete_Click(bool deleteConfirmed)
    {
        if (deleteConfirmed)
        {
            if (objMain.Contains(userDelete))
            {
                var res = UserService.DeleteUserServiceAsync(userDelete.Id);
                await reload();
                await usersGrid.Reload();
            }
            else
            {
                usersGrid.CancelEditRow(userDelete);
            }
        }
    }

    protected async Task ConfirmDeleteMultiple_Click(bool deleteConfirmed)
    {
        if (deleteConfirmed)
        {
            var check = objMain.Where(x => x.Check == true).ToList();
            await UserService.DeleteMultipleUserServiceAsync(check);
            await reload();
            await usersGrid.Reload();

        }
    }

    async Task EditRow(UserDto user)
    {
        var options = new ModalOptions()
        {
            Animation = ModalAnimation.FadeInOut(1)
        };

        var parameters = new ModalParameters();
        parameters.Add(nameof(user.Id), user.Id);

        var formModal = modal.Show<UpdateUser>("Actualizar Usuario", parameters, options);
        var result = await formModal.Result;

        if (result.Cancelled)
        {
            await reload();
            await usersGrid.Reload();
        }
        else
        {
            Console.WriteLine(result.Data);
        }
    }

    async Task ShowModalAdd()
    {
        var options = new ModalOptions()
        {
            Animation = ModalAnimation.FadeInOut(1)
        };
        var formModal = modal.Show<AltaUsuario>("Alta Usuario",options);
        var result = await formModal.Result;

        if (result.Cancelled)
        {
            await reload();
            await usersGrid.Reload();
        }
        else
        {
            Console.WriteLine(result.Data);
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserServiceAdmin UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService modal { get; set; }
    }
}
#pragma warning restore 1591
