#pragma checksum "C:\Users\vusi\source\repos\DeviceManagement\DeviceManagement\Pages\AddOperation.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "c84919490730088b663a9b64e689ccef757ac594fd5af869d34968bfe49c2a76"
// <auto-generated/>
#pragma warning disable 1591
namespace DeviceManagement.Pages
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\vusi\source\repos\DeviceManagement\DeviceManagement\_Imports.razor"
using System.Net.Http

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\vusi\source\repos\DeviceManagement\DeviceManagement\_Imports.razor"
using Microsoft.AspNetCore.Authorization

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\vusi\source\repos\DeviceManagement\DeviceManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\vusi\source\repos\DeviceManagement\DeviceManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\vusi\source\repos\DeviceManagement\DeviceManagement\_Imports.razor"
using Microsoft.AspNetCore.Components.Web

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\vusi\source\repos\DeviceManagement\DeviceManagement\_Imports.razor"
using Microsoft.JSInterop

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\vusi\source\repos\DeviceManagement\DeviceManagement\_Imports.razor"
using DeviceManagement

#nullable disable
    ;
#nullable restore
#line 9 "C:\Users\vusi\source\repos\DeviceManagement\DeviceManagement\_Imports.razor"
using DeviceManagement.Shared

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\vusi\source\repos\DeviceManagement\DeviceManagement\Pages\AddOperation.razor"
 using DeviceManagement.Services

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\vusi\source\repos\DeviceManagement\DeviceManagement\Pages\AddOperation.razor"
 using DeviceManagement.Models

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\vusi\source\repos\DeviceManagement\DeviceManagement\Pages\AddOperation.razor"
 using Microsoft.AspNetCore.Components.Forms

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Components.RouteAttribute(
    // language=Route,Component
#nullable restore
#line 1 "C:\Users\vusi\source\repos\DeviceManagement\DeviceManagement\Pages\AddOperation.razor"
      "/add-operation"

#line default
#line hidden
#nullable disable
    )]
    #nullable restore
    public partial class AddOperation : global::Microsoft.AspNetCore.Components.ComponentBase
    #nullable disable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"text-align:center;\">Add New Operation</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card");
            __builder.AddAttribute(3, "style", "margin: 0 auto; max-width: 195%;");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.AddAttribute(7, "style", "padding: 40px;");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(9);
            __builder.AddAttribute(10, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 11 "C:\Users\vusi\source\repos\DeviceManagement\DeviceManagement\Pages\AddOperation.razor"
                         newOperation

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "OnValidSubmit", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\vusi\source\repos\DeviceManagement\DeviceManagement\Pages\AddOperation.razor"
                                                      HandleValidSubmit

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(12, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationSummary>(16);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n            ");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group");
                __builder2.AddMarkupContent(20, "\r\n                ");
                __builder2.AddMarkupContent(21, "<label for=\"name\">Name</label>\r\n                ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "id", (object)("name"));
                __builder2.AddAttribute(24, "class", (object)("form-control"));
                __builder2.AddAttribute(25, "style", (object)("width: 75%;"));
                __builder2.AddAttribute(26, "Value", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 16 "C:\Users\vusi\source\repos\DeviceManagement\DeviceManagement\Pages\AddOperation.razor"
                                                                       newOperation.Name

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(27, "ValueChanged", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newOperation.Name = __value, newOperation.Name)))));
                __builder2.AddAttribute(28, "ValueExpression", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newOperation.Name)));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddMarkupContent(33, "\r\n                ");
                __builder2.AddMarkupContent(34, "<label for=\"order\">Order</label>\r\n                ");
                global::__Blazor.DeviceManagement.Pages.AddOperation.TypeInference.CreateInputNumber_0(__builder2, 35, 36, "order", 37, "form-control", 38, "width: 75%;", 39, 
#nullable restore
#line 20 "C:\Users\vusi\source\repos\DeviceManagement\DeviceManagement\Pages\AddOperation.razor"
                                                                          newOperation.OrderInWhichToPerform

#line default
#line hidden
#nullable disable
                , 40, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newOperation.OrderInWhichToPerform = __value, newOperation.OrderInWhichToPerform)), 41, () => newOperation.OrderInWhichToPerform);
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n            ");
                __builder2.AddMarkupContent(44, "<div style=\"text-align: center;\">\r\n                <button type=\"submit\" class=\"btn btn-primary\">Add Operation</button>\r\n            </div>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\vusi\source\repos\DeviceManagement\DeviceManagement\Pages\AddOperation.razor"
       
    private Operation newOperation = new Operation();

    private void HandleValidSubmit()
    {
        OperationService.AddOperation(newOperation);
        Navigation.NavigateTo("/operations");
    }

#line default
#line hidden
#nullable disable

        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 5 "C:\Users\vusi\source\repos\DeviceManagement\DeviceManagement\Pages\AddOperation.razor"
        NavigationManager

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 5 "C:\Users\vusi\source\repos\DeviceManagement\DeviceManagement\Pages\AddOperation.razor"
                          Navigation

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private 
#nullable restore
#line 4 "C:\Users\vusi\source\repos\DeviceManagement\DeviceManagement\Pages\AddOperation.razor"
        OperationService

#line default
#line hidden
#nullable disable
         
#nullable restore
#line 4 "C:\Users\vusi\source\repos\DeviceManagement\DeviceManagement\Pages\AddOperation.razor"
                         OperationService

#line default
#line hidden
#nullable disable
         { get; set; }
         = default!;
    }
}
namespace __Blazor.DeviceManagement.Pages.AddOperation
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, global::System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", (object)__arg0);
        __builder.AddAttribute(__seq1, "class", (object)__arg1);
        __builder.AddAttribute(__seq2, "style", (object)__arg2);
        __builder.AddAttribute(__seq3, "Value", (object)__arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", (object)__arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", (object)__arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
