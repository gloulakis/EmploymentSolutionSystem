#pragma checksum "C:\Users\Administrator\Documents\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\Companies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38212e167bb976430553bcf247fd67c7a220b3a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Companies), @"mvc.1.0.view", @"/Views/Home/Companies.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Administrator\Documents\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\_ViewImports.cshtml"
using EmploymentSolutionSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Documents\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\_ViewImports.cshtml"
using EmploymentSolutionSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Documents\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\_ViewImports.cshtml"
using EmploymentSolutionSystem.Domain.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38212e167bb976430553bcf247fd67c7a220b3a4", @"/Views/Home/Companies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2737ee6aec5ec161a71b3407c043c6c8682691b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Companies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Company>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateCompany", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Administrator\Documents\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\Companies.cshtml"
  
    ViewData["Title"] = "Company Information";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"border border-white\">\r\n\r\n    <div class=\"form-row\">\r\n        <div class=\"col-6\">\r\n            <h4 class=\"text-info\">Companies</h4>\r\n        </div>\r\n        <div class=\"col-6 text-right\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38212e167bb976430553bcf247fd67c7a220b3a44577", async() => {
                WriteLiteral("Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <div>\r\n");
#nullable restore
#line 18 "C:\Users\Administrator\Documents\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\Companies.cshtml"
         if (Model == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Empty</p>\r\n");
#nullable restore
#line 21 "C:\Users\Administrator\Documents\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\Companies.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table"">
                <thead class=""thead-dark"">
                    <tr>
                        <th scope=""col"">Company Name</th>
                        <th scope=""col"">Telephone Number</th>
                        <th scope=""col"">E-mail</th>
                        <th scope=""col""></th>
                        <th scope=""col""></th>
                        <th scope=""col""></th>
                    </tr>
                </thead>
");
#nullable restore
#line 35 "C:\Users\Administrator\Documents\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\Companies.cshtml"
                 foreach (var Company in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tbody>\r\n                        <tr>\r\n\r\n                            <td>");
#nullable restore
#line 40 "C:\Users\Administrator\Documents\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\Companies.cshtml"
                           Write(Html.DisplayFor(m => Company.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 41 "C:\Users\Administrator\Documents\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\Companies.cshtml"
                           Write(Html.DisplayFor(m => Company.CompanyTelephoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 42 "C:\Users\Administrator\Documents\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\Companies.cshtml"
                           Write(Html.DisplayFor(m => Company.CompanyEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            <td scope=\"col\"><a");
            BeginWriteAttribute("onclick", " onclick=\"", 1413, "\"", 1442, 3);
            WriteAttributeValue("", 1423, "edit(\'", 1423, 6, true);
#nullable restore
#line 44 "C:\Users\Administrator\Documents\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\Companies.cshtml"
WriteAttributeValue("", 1429, Company.Id, 1429, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1440, "\')", 1440, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\"><i class=\"far fa-edit\"></i></a></td>\r\n                            <td scope=\"col\"><a");
            BeginWriteAttribute("onclick", " onclick=\"", 1560, "\"", 1626, 5);
            WriteAttributeValue("", 1570, "GetCompanyToDelete(\'", 1570, 20, true);
#nullable restore
#line 45 "C:\Users\Administrator\Documents\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\Companies.cshtml"
WriteAttributeValue("", 1590, Company.Id, 1590, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1601, "\',\'", 1601, 3, true);
#nullable restore
#line 45 "C:\Users\Administrator\Documents\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\Companies.cshtml"
WriteAttributeValue("", 1604, Company.CompanyName, 1604, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1624, "\')", 1624, 2, true);
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"modal\" data-target=\"#exampleModal\" class=\"btn btn-outline-danger\"><i class=\"far fa-trash-alt\"></i></a></td>\r\n                            <td scope=\"col\"><a");
            BeginWriteAttribute("onclick", " onclick=\"", 1796, "\"", 1825, 3);
            WriteAttributeValue("", 1806, "hide(\'", 1806, 6, true);
#nullable restore
#line 46 "C:\Users\Administrator\Documents\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\Companies.cshtml"
WriteAttributeValue("", 1812, Company.Id, 1812, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1823, "\')", 1823, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\"><i class=\"far fa-eye-slash\"></i></a></td>\r\n\r\n                        </tr>\r\n                    </tbody>\r\n");
#nullable restore
#line 50 "C:\Users\Administrator\Documents\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\Companies.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n");
#nullable restore
#line 52 "C:\Users\Administrator\Documents\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\Companies.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</div>

<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Delete</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <p>Are you sure - <span id=""CompanytoDeleteName""></span><span hidden id=""CompanyIDToDelete""></span></p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                <button onclick=""DeleteCompany()"" type=""button"" class=""btn btn-primary"">Delete</button>
            </div>
        </div>
    </div");
            WriteLiteral(@">
</div>



<script>
    function edit(id) {
        window.location =""/Home/Edit/""+id
    }

    function GetCompanyToDelete(id, Title) {
        var $Title = $(""#CompanytoDeleteName"");
        var $id = $(""#CompanyIDToDelete"");

        $Title.html(Title);
        $id.html(id);
    }

    function DeleteCompany() {
        var $id = $(""#CompanyIDToDelete"").html();
        window.location = ""/Home/DeleteCompany/""+ $id;
    }



</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Company>> Html { get; private set; }
    }
}
#pragma warning restore 1591