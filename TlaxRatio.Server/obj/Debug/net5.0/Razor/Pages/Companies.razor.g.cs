#pragma checksum "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\Pages\Companies.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26d9e31b1f8463eb8b9405022c6104938c449f93"
// <auto-generated/>
#pragma warning disable 1591
namespace TlaxRatio.Server.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\_Imports.razor"
using TlaxRatio.Layouts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\Pages\_Imports.razor"
using TlaxRatio.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\Pages\_Imports.razor"
using TlaxRatio.Server.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\Pages\Companies.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\Pages\Companies.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\Pages\Companies.razor"
using TlaxRatio.Models.SimpleInvoice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\Pages\Companies.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\Pages\Companies.razor"
using TlaxRatio.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\Pages\Companies.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\Pages\Companies.razor"
           [Authorize(Roles="Authenticated, Invoicing")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/companies")]
    public partial class Companies : TlaxRatio.Server.Pages.CompaniesComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.RadzenContent>(0);
            __builder.AddAttribute(1, "Container", "main");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenHeading>(3);
                __builder2.AddAttribute(4, "Size", "H1");
                __builder2.AddAttribute(5, "Text", "Companies");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "row");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "col-md-12");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(11);
                __builder2.AddAttribute(12, "Icon", "add_circle_outline");
                __builder2.AddAttribute(13, "style", "margin-bottom: 10px");
                __builder2.AddAttribute(14, "Text", "Add");
                __builder2.AddAttribute(15, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\Pages\Companies.razor"
                                                                                               Button0Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenSplitButton>(17);
                __builder2.AddAttribute(18, "Icon", "get_app");
                __builder2.AddAttribute(19, "style", "margin-bottom: 10px; margin-left: 10px");
                __builder2.AddAttribute(20, "Text", "Export");
                __builder2.AddAttribute(21, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.Blazor.RadzenSplitButtonItem>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.Blazor.RadzenSplitButtonItem>(this, 
#nullable restore
#line 23 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\Pages\Companies.razor"
                                                                                                               Splitbutton0Click

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenSplitButtonItem>(23);
                    __builder3.AddAttribute(24, "Text", "Excel");
                    __builder3.AddAttribute(25, "Value", "xlsx");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(26, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenSplitButtonItem>(27);
                    __builder3.AddAttribute(28, "Text", "CSV");
                    __builder3.AddAttribute(29, "Value", "csv");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenTextBox>(31);
                __builder2.AddAttribute(32, "Placeholder", "Search ...");
                __builder2.AddAttribute(33, "style", "display: block; margin-bottom: 10px; width: 100%");
                __builder2.AddAttribute(34, "Name", "Textbox0");
                __builder2.AddAttribute(35, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 31 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\Pages\Companies.razor"
                                                                                                                                     async(args) => {search = $"{args.Value}";await grid0.GoToPage(0);await Load();}

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n        ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGrid<TlaxRatio.Models.SimpleInvoice.Company>>(37);
                __builder2.AddAttribute(38, "AllowFiltering", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 33 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\Pages\Companies.razor"
                                                 true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "AllowPaging", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 33 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\Pages\Companies.razor"
                                                                    true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(40, "AllowSorting", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 33 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\Pages\Companies.razor"
                                                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "Data", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<TlaxRatio.Models.SimpleInvoice.Company>>(
#nullable restore
#line 33 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\Pages\Companies.razor"
                                                                                                     getCompaniesResult

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "FilterMode", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.FilterMode>(
#nullable restore
#line 33 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\Pages\Companies.razor"
                                                                                                                                     FilterMode.Advanced

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "RowSelect", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<TlaxRatio.Models.SimpleInvoice.Company>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<TlaxRatio.Models.SimpleInvoice.Company>(this, 
#nullable restore
#line 33 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\Pages\Companies.razor"
                                                                                                                                                                                                                     Grid0RowSelect

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(44, "Columns", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TlaxRatio.Models.SimpleInvoice.Company>>(45);
                    __builder3.AddAttribute(46, "Property", "CompanyId");
                    __builder3.AddAttribute(47, "Title", "Company Id");
                    __builder3.AddAttribute(48, "Visible", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 35 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\Pages\Companies.razor"
                                                                                                                              false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(49, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TlaxRatio.Models.SimpleInvoice.Company>>(50);
                    __builder3.AddAttribute(51, "Property", "Name");
                    __builder3.AddAttribute(52, "Title", "Name");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(53, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TlaxRatio.Models.SimpleInvoice.Company>>(54);
                    __builder3.AddAttribute(55, "Property", "Description");
                    __builder3.AddAttribute(56, "Title", "Description");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(57, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TlaxRatio.Models.SimpleInvoice.Company>>(58);
                    __builder3.AddAttribute(59, "Property", "Address");
                    __builder3.AddAttribute(60, "Title", "Address");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(61, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TlaxRatio.Models.SimpleInvoice.Company>>(62);
                    __builder3.AddAttribute(63, "Property", "City");
                    __builder3.AddAttribute(64, "Title", "City");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(65, "\r\n            ");
                    __builder3.OpenComponent<Radzen.Blazor.RadzenGridColumn<TlaxRatio.Models.SimpleInvoice.Company>>(66);
                    __builder3.AddAttribute(67, "Filterable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 45 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\Pages\Companies.razor"
                                                                                         false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(68, "Sortable", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 45 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\Pages\Companies.razor"
                                                                                                          false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(69, "TextAlign", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.TextAlign>(
#nullable restore
#line 45 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\Pages\Companies.razor"
                                                                                                                            TextAlign.Center

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(70, "Width", "70px");
                    __builder3.AddAttribute(71, "Template", (Microsoft.AspNetCore.Components.RenderFragment<TlaxRatio.Models.SimpleInvoice.Company>)((TlaxRatioModelsSimpleInvoiceCompany) => (__builder4) => {
                        __builder4.OpenComponent<Radzen.Blazor.RadzenButton>(72);
                        __builder4.AddAttribute(73, "ButtonStyle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonStyle>(
#nullable restore
#line 47 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\Pages\Companies.razor"
                                           ButtonStyle.Danger

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(74, "Icon", "close");
                        __builder4.AddAttribute(75, "Size", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.ButtonSize>(
#nullable restore
#line 47 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\Pages\Companies.razor"
                                                                                  ButtonSize.Small

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(76, "Visible", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 47 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\Pages\Companies.razor"
                                                                                                               TlaxRatioModelsSimpleInvoiceCompany.CompanyId != 1

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(77, "Click", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\Pages\Companies.razor"
                                                                                                                                                                             (args) =>GridDeleteButtonClick(args, TlaxRatioModelsSimpleInvoiceCompany)

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddEventStopPropagationAttribute(78, "onclick", 
#nullable restore
#line 47 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\Pages\Companies.razor"
                                                                                                                                                                                                                                                                                   true

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddComponentReferenceCapture(79, (__value) => {
#nullable restore
#line 33 "D:\bbGIT\bbteam17\BlazorExampleInvoiceManagementSoftware\TlaxRatio.Server\Pages\Companies.razor"
                          grid0 = (Radzen.Blazor.RadzenGrid<TlaxRatio.Models.SimpleInvoice.Company>)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591