#pragma checksum "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\UpdateUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09e9fb20d9ef9cd926d2ac7a43c221fab256ea0d"
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
#nullable restore
#line 2 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\UpdateUser.razor"
using NojomoApp.Data.UserData;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/updateUser/{Id}")]
    public partial class UpdateUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<NojomoApp.Shared.Validations>(0);
            __builder.AddAttribute(1, "IsVisible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\UpdateUser.razor"
                        IsVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Result", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\UpdateUser.razor"
                                           Result

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "<span>Ususario : </span>");
                __builder2.AddContent(5, 
#nullable restore
#line 12 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\UpdateUser.razor"
                             RecordName

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenFieldset>(7);
            __builder.AddAttribute(8, "Text", "Datos del usuario");
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(10);
                __builder2.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\UpdateUser.razor"
                      user

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 17 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\UpdateUser.razor"
                                            SaveUser

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(14);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(15, "\r\n\r\n        ");
                    __builder3.OpenElement(16, "div");
                    __builder3.AddAttribute(17, "class", "col-12 row");
                    __builder3.AddMarkupContent(18, "<label class=\"col-2 font-weight-bold\">Alias :</label>\r\n            ");
                    __builder3.OpenElement(19, "input");
                    __builder3.AddAttribute(20, "class", "form-control col-3");
                    __builder3.AddAttribute(21, "placeholder", "alias");
                    __builder3.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\UpdateUser.razor"
                                                                          user.Alias

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Alias = __value, user.Alias));
                    __builder3.SetUpdatesAttributeName("value");
                    __builder3.AddElementReferenceCapture(24, (__value) => {
#nullable restore
#line 22 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\UpdateUser.razor"
                         firstNameText = __value;

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(25, "\r\n            &nbsp;");
                    __Blazor.NojomoApp.Pages.UpdateUser.TypeInference.CreateValidationMessage_0(__builder3, 26, 27, 
#nullable restore
#line 23 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\UpdateUser.razor"
                                            () => user.Alias

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(28, "\r\n        <br>\r\n        ");
                    __builder3.OpenElement(29, "div");
                    __builder3.AddAttribute(30, "class", "col-12 row");
                    __builder3.AddMarkupContent(31, "<label class=\"col-2 font-weight-bold\">Nombre :</label>\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                    __builder3.AddAttribute(33, "class", "form-control col-3");
                    __builder3.AddAttribute(34, "placeholder", "nombre");
                    __builder3.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\UpdateUser.razor"
                                                               user.Nombre

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Nombre = __value, user.Nombre))));
                    __builder3.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Nombre));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\r\n            &nbsp;");
                    __Blazor.NojomoApp.Pages.UpdateUser.TypeInference.CreateValidationMessage_1(__builder3, 39, 40, 
#nullable restore
#line 29 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\UpdateUser.razor"
                                            () => user.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(41, "\r\n        <br>\r\n        ");
                    __builder3.OpenElement(42, "div");
                    __builder3.AddAttribute(43, "class", "col-12 row");
                    __builder3.AddMarkupContent(44, "<label class=\"col-2 font-weight-bold\">Tipo :</label>\r\n            ");
                    __Blazor.NojomoApp.Pages.UpdateUser.TypeInference.CreateInputSelect_2(__builder3, 45, 46, "form-control col-3", 47, 
#nullable restore
#line 34 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\UpdateUser.razor"
                                      user.Tipo

#line default
#line hidden
#nullable disable
                    , 48, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Tipo = __value, user.Tipo)), 49, () => user.Tipo, 50, (__builder4) => {
#nullable restore
#line 35 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\UpdateUser.razor"
                 if (@Tipo != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\UpdateUser.razor"
                     foreach (var tipo in Tipo)
                    {

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(51, "option");
                        __builder4.AddAttribute(52, "value", "1");
                        __builder4.AddContent(53, 
#nullable restore
#line 39 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\UpdateUser.razor"
                                           tipo

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
#nullable restore
#line 40 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\UpdateUser.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\UpdateUser.razor"
                     
                }

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(54, "\r\n        <br>\r\n        ");
                    __builder3.OpenElement(55, "div");
                    __builder3.AddAttribute(56, "class", "col-12 row");
                    __builder3.AddMarkupContent(57, "<label class=\"col-2 font-weight-bold\">Precio :</label>\r\n            ");
                    __Blazor.NojomoApp.Pages.UpdateUser.TypeInference.CreateInputNumber_3(__builder3, 58, 59, "form-control col-3", 60, "precio", 61, 
#nullable restore
#line 50 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\UpdateUser.razor"
                                                                 user.Precio

#line default
#line hidden
#nullable disable
                    , 62, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Precio = __value, user.Precio)), 63, () => user.Precio);
                    __builder3.AddMarkupContent(64, "\r\n            &nbsp;");
                    __Blazor.NojomoApp.Pages.UpdateUser.TypeInference.CreateValidationMessage_4(__builder3, 65, 66, 
#nullable restore
#line 51 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\UpdateUser.razor"
                                            () => user.Precio

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(67, "\r\n        <br>\r\n        ");
                    __builder3.OpenElement(68, "div");
                    __builder3.AddAttribute(69, "class", "col-12 row");
                    __builder3.AddMarkupContent(70, "<label class=\"col-2 font-weight-bold\">Email :</label>\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(71);
                    __builder3.AddAttribute(72, "class", "form-control col-3");
                    __builder3.AddAttribute(73, "placeholder", "email");
                    __builder3.AddAttribute(74, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\UpdateUser.razor"
                                                               user.Email

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(75, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Email = __value, user.Email))));
                    __builder3.AddAttribute(76, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Email));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(77, "\r\n            &nbsp;");
                    __Blazor.NojomoApp.Pages.UpdateUser.TypeInference.CreateValidationMessage_5(__builder3, 78, 79, 
#nullable restore
#line 57 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\UpdateUser.razor"
                                            () => user.Email

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(80, "\r\n        <br>\r\n        ");
                    __builder3.OpenElement(81, "div");
                    __builder3.AddAttribute(82, "class", "col-12 row");
                    __builder3.AddMarkupContent(83, "<label class=\"col-2 font-weight-bold\">Telefono:</label>\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(84);
                    __builder3.AddAttribute(85, "class", "form-control col-3");
                    __builder3.AddAttribute(86, "placeholder", "telefono");
                    __builder3.AddAttribute(87, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 62 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\UpdateUser.razor"
                                                               user.Telefono

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(88, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Telefono = __value, user.Telefono))));
                    __builder3.AddAttribute(89, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Telefono));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(90, "\r\n            &nbsp;");
                    __Blazor.NojomoApp.Pages.UpdateUser.TypeInference.CreateValidationMessage_6(__builder3, 91, 92, 
#nullable restore
#line 63 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\UpdateUser.razor"
                                            () => user.Telefono

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(93, "\r\n        <br>\r\n        ");
                    __builder3.OpenElement(94, "div");
                    __builder3.AddAttribute(95, "class", "col-12 row");
                    __builder3.AddMarkupContent(96, "<label class=\"col-2 font-weight-bold\">Password :</label>\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPassword>(97);
                    __builder3.AddAttribute(98, "class", "form-control col-3");
                    __builder3.AddAttribute(99, "placeholder", "password");
                    __builder3.AddAttribute(100, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 68 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\UpdateUser.razor"
                                                                    user.Password

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(101, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.Password = __value, user.Password))));
                    __builder3.AddAttribute(102, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.Password));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(103, "\r\n            &nbsp;");
                    __Blazor.NojomoApp.Pages.UpdateUser.TypeInference.CreateValidationMessage_7(__builder3, 104, 105, 
#nullable restore
#line 70 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\UpdateUser.razor"
                                            () => user.Password

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(106, "\r\n        <br>\r\n        ");
                    __builder3.OpenElement(107, "div");
                    __builder3.AddAttribute(108, "class", "col-12 row");
                    __builder3.AddMarkupContent(109, "<label class=\"col-2 font-weight-bold\">Confirmar Password :</label>\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenPassword>(110);
                    __builder3.AddAttribute(111, "class", "form-control col-3");
                    __builder3.AddAttribute(112, "placeholder", "Confirmar password");
                    __builder3.AddAttribute(113, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 75 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\UpdateUser.razor"
                                                                    user.ConfirmPassword

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(114, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => user.ConfirmPassword = __value, user.ConfirmPassword))));
                    __builder3.AddAttribute(115, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => user.ConfirmPassword));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(116, "\r\n            &nbsp;");
                    __Blazor.NojomoApp.Pages.UpdateUser.TypeInference.CreateValidationMessage_8(__builder3, 117, 118, 
#nullable restore
#line 77 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\UpdateUser.razor"
                                            () => user.ConfirmPassword

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(119, "\r\n        <br>\r\n\r\n        <br>\r\n        ");
                    __builder3.AddMarkupContent(120, "<div class=\"col-12 row\"><span class=\"col-2\"></span>\r\n            <input type=\"submit\" class=\"form-control col-1 btn btn-primary\" value=\"Save\">\r\n            <span>&nbsp;</span></div>");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 95 "C:\Users\Admin\Desktop\Escritorio\Trabajo\NojomoAppRepositorio\NojomoApp\Pages\UpdateUser.razor"
       
    [Parameter]
    public int Id { get; set; }

    public UserDto user { get; set; }
    ElementReference firstNameText;
    public string[] Tipo { get; set; }

    public bool IsVisible { get; set; }
    public string RecordName { get; set; }
    public bool Result { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender && Tipo == null)
        {
            Tipo = await JSRuntime.InvokeAsync<string[]>("getTipo");
            StateHasChanged();
        }
    }

    protected override async Task OnInitializedAsync()
    {
        user = new UserDto();
        user = await UserService.GetUserIdServiceAsync(Id);
    }

    private async Task SaveUser()
    {
        Result = await UserService.UpdateUserServiceAsync(user.Id, user);
        IsVisible = true;

        var nombre = user.Nombre;
        RecordName = nombre;

        user = new Data.UserData.UserDto();

        // await JSRuntime.InvokeVoidAsync("saveMessage", nombre);
        await JSRuntime.InvokeVoidAsync("setFocusOnElement", firstNameText);
        //navigationManager.NavigateTo($"/usuarios");


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
    }
}
namespace __Blazor.NojomoApp.Pages.UpdateUser
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "placeholder", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
