#pragma checksum "C:\Users\marci\OneDrive\Área de Trabalho\ASP.Net\workshop-asp-net-core-mvc-master\workshop-asp-net-core-mvc-master\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0819e26a2419120fbd244b2955a1edd7e726d21a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SalesRecords_GroupingSearch), @"mvc.1.0.view", @"/Views/SalesRecords/GroupingSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SalesRecords/GroupingSearch.cshtml", typeof(AspNetCore.Views_SalesRecords_GroupingSearch))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\marci\OneDrive\Área de Trabalho\ASP.Net\workshop-asp-net-core-mvc-master\workshop-asp-net-core-mvc-master\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc;

#line default
#line hidden
#line 2 "C:\Users\marci\OneDrive\Área de Trabalho\ASP.Net\workshop-asp-net-core-mvc-master\workshop-asp-net-core-mvc-master\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0819e26a2419120fbd244b2955a1edd7e726d21a", @"/Views/SalesRecords/GroupingSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30e82a99d0f68a83eb80a8c42eea95417221ff4a", @"/Views/_ViewImports.cshtml")]
    public class Views_SalesRecords_GroupingSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IGrouping<Department, SalesRecord>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\marci\OneDrive\Área de Trabalho\ASP.Net\workshop-asp-net-core-mvc-master\workshop-asp-net-core-mvc-master\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
  
    ViewData["Title"] = "Grouping Search";
    DateTime minDate = DateTime.Parse(ViewData["minDate"] as string);
    DateTime maxDate = DateTime.Parse(ViewData["maxDate"] as string);

#line default
#line hidden
            BeginContext(244, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(250, 17, false);
#line 9 "C:\Users\marci\OneDrive\Área de Trabalho\ASP.Net\workshop-asp-net-core-mvc-master\workshop-asp-net-core-mvc-master\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(267, 85, true);
            WriteLiteral("</h2>\n\n<nav class=\"navbar navbar-inverse\">\n    <div class=\"container-fluid\">\n        ");
            EndContext();
            BeginContext(352, 648, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81a3ca831fde4553a7523cb5a005a380", async() => {
                BeginContext(404, 211, true);
                WriteLiteral("\n            <div class=\"form-group\">\n                <div class=\"form-group\">\n                    <label for=\"minDate\">Min Date</label>\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 615, "", 642, 1);
#line 17 "C:\Users\marci\OneDrive\Área de Trabalho\ASP.Net\workshop-asp-net-core-mvc-master\workshop-asp-net-core-mvc-master\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
WriteAttributeValue("", 622, ViewData["minDate"], 622, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(642, 198, true);
                WriteLiteral(">\n                </div>\n                <div class=\"form-group\">\n                    <label for=\"maxDate\">Max Date</label>\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 840, "", 867, 1);
#line 21 "C:\Users\marci\OneDrive\Área de Trabalho\ASP.Net\workshop-asp-net-core-mvc-master\workshop-asp-net-core-mvc-master\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
WriteAttributeValue("", 847, ViewData["maxDate"], 847, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(867, 126, true);
                WriteLiteral(">\n                </div>\n            </div>\n            <button type=\"submit\" class=\"btn btn-primary\">Filter</button>\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1000, 20, true);
            WriteLiteral("\n    </div>\n</nav>\n\n");
            EndContext();
#line 29 "C:\Users\marci\OneDrive\Área de Trabalho\ASP.Net\workshop-asp-net-core-mvc-master\workshop-asp-net-core-mvc-master\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
 foreach (var departmentGroup in Model)
{

#line default
#line hidden
            BeginContext(1062, 121, true);
            WriteLiteral("    <div class=\"panel panel-primary\">\n        <div class=\"panel-heading\">\n            <h3 class=\"panel-title\">Department ");
            EndContext();
            BeginContext(1184, 24, false);
#line 33 "C:\Users\marci\OneDrive\Área de Trabalho\ASP.Net\workshop-asp-net-core-mvc-master\workshop-asp-net-core-mvc-master\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                                          Write(departmentGroup.Key.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1208, 16, true);
            WriteLiteral(", Total sales = ");
            EndContext();
            BeginContext(1225, 63, false);
#line 33 "C:\Users\marci\OneDrive\Área de Trabalho\ASP.Net\workshop-asp-net-core-mvc-master\workshop-asp-net-core-mvc-master\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                                                                                   Write(departmentGroup.Key.TotalSales(minDate, maxDate).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1288, 628, true);
            WriteLiteral(@"</h3>
        </div>
        <div class=""panel-body"">
            <table class=""table table-striped table-hover"">
                <thead>
                    <tr class=""success"">
                        <th>
                            Date
                        </th>
                        <th>
                            Amount
                        </th>
                        <th>
                            Seller
                        </th>
                        <th>
                            Status
                        </th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 54 "C:\Users\marci\OneDrive\Área de Trabalho\ASP.Net\workshop-asp-net-core-mvc-master\workshop-asp-net-core-mvc-master\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                     foreach (var item in departmentGroup)
                    {

#line default
#line hidden
            BeginContext(1997, 94, true);
            WriteLiteral("                        <tr>\n                            <td>\n                                ");
            EndContext();
            BeginContext(2092, 39, false);
#line 58 "C:\Users\marci\OneDrive\Área de Trabalho\ASP.Net\workshop-asp-net-core-mvc-master\workshop-asp-net-core-mvc-master\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(2131, 100, true);
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
            EndContext();
            BeginContext(2232, 41, false);
#line 61 "C:\Users\marci\OneDrive\Área de Trabalho\ASP.Net\workshop-asp-net-core-mvc-master\workshop-asp-net-core-mvc-master\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(2273, 100, true);
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
            EndContext();
            BeginContext(2374, 46, false);
#line 64 "C:\Users\marci\OneDrive\Área de Trabalho\ASP.Net\workshop-asp-net-core-mvc-master\workshop-asp-net-core-mvc-master\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Seller.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2420, 100, true);
            WriteLiteral("\n                            </td>\n                            <td>\n                                ");
            EndContext();
            BeginContext(2521, 41, false);
#line 67 "C:\Users\marci\OneDrive\Área de Trabalho\ASP.Net\workshop-asp-net-core-mvc-master\workshop-asp-net-core-mvc-master\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2562, 65, true);
            WriteLiteral("\n                            </td>\n                        </tr>\n");
            EndContext();
#line 70 "C:\Users\marci\OneDrive\Área de Trabalho\ASP.Net\workshop-asp-net-core-mvc-master\workshop-asp-net-core-mvc-master\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                    }

#line default
#line hidden
            BeginContext(2649, 72, true);
            WriteLiteral("                </tbody>\n            </table>\n        </div>\n    </div>\n");
            EndContext();
#line 75 "C:\Users\marci\OneDrive\Área de Trabalho\ASP.Net\workshop-asp-net-core-mvc-master\workshop-asp-net-core-mvc-master\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IGrouping<Department, SalesRecord>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
