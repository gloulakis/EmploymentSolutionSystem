#pragma checksum "C:\Users\Georgios.Loulakis\Source\Repos\gloulakis\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Company\Company.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e83fb8f2baa90c0551285459e0d712842787482"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_Company), @"mvc.1.0.view", @"/Views/Company/Company.cshtml")]
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
#line 1 "C:\Users\Georgios.Loulakis\Source\Repos\gloulakis\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\_ViewImports.cshtml"
using EmploymentSolutionSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Georgios.Loulakis\Source\Repos\gloulakis\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\_ViewImports.cshtml"
using EmploymentSolutionSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Georgios.Loulakis\Source\Repos\gloulakis\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\_ViewImports.cshtml"
using EmploymentSolutionSystem.Domain.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e83fb8f2baa90c0551285459e0d712842787482", @"/Views/Company/Company.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2737ee6aec5ec161a71b3407c043c6c8682691b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_Company : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Company>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Company", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateCompany", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Georgios.Loulakis\Source\Repos\gloulakis\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Company\Company.cshtml"
  
    ViewData["Title"] = "Company Information";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"border border-white\">\r\n\r\n    <div class=\"form-row\">\r\n        <div class=\"col-6\">\r\n            <h4 class=\"text-info\">Companies</h4>\r\n        </div>\r\n        <div class=\"col-6 text-right\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e83fb8f2baa90c0551285459e0d7128427874824974", async() => {
                WriteLiteral("Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <div>\r\n");
#nullable restore
#line 18 "C:\Users\Georgios.Loulakis\Source\Repos\gloulakis\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Company\Company.cshtml"
         if (Model == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Empty</p>\r\n");
#nullable restore
#line 21 "C:\Users\Georgios.Loulakis\Source\Repos\gloulakis\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Company\Company.cshtml"
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
#line 35 "C:\Users\Georgios.Loulakis\Source\Repos\gloulakis\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Company\Company.cshtml"
                 foreach (var Company in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tbody>\r\n                        <tr>\r\n\r\n                            <td>");
#nullable restore
#line 40 "C:\Users\Georgios.Loulakis\Source\Repos\gloulakis\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Company\Company.cshtml"
                           Write(Html.DisplayFor(m => Company.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 41 "C:\Users\Georgios.Loulakis\Source\Repos\gloulakis\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Company\Company.cshtml"
                           Write(Html.DisplayFor(m => Company.CompanyTelephoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 42 "C:\Users\Georgios.Loulakis\Source\Repos\gloulakis\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Company\Company.cshtml"
                           Write(Html.DisplayFor(m => Company.CompanyEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            <td scope=\"col\"><a");
            BeginWriteAttribute("onclick", " onclick=\"", 1438, "\"", 1467, 3);
            WriteAttributeValue("", 1448, "edit(\'", 1448, 6, true);
#nullable restore
#line 44 "C:\Users\Georgios.Loulakis\Source\Repos\gloulakis\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Company\Company.cshtml"
WriteAttributeValue("", 1454, Company.Id, 1454, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1465, "\')", 1465, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\"><i class=\"far fa-edit\"></i></a></td>\r\n                            <td scope=\"col\"><a");
            BeginWriteAttribute("onclick", " onclick=\"", 1585, "\"", 1651, 5);
            WriteAttributeValue("", 1595, "GetCompanyToDelete(\'", 1595, 20, true);
#nullable restore
#line 45 "C:\Users\Georgios.Loulakis\Source\Repos\gloulakis\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Company\Company.cshtml"
WriteAttributeValue("", 1615, Company.Id, 1615, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1626, "\',\'", 1626, 3, true);
#nullable restore
#line 45 "C:\Users\Georgios.Loulakis\Source\Repos\gloulakis\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Company\Company.cshtml"
WriteAttributeValue("", 1629, Company.CompanyName, 1629, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1649, "\')", 1649, 2, true);
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"modal\" data-target=\"#exampleModal\" class=\"btn btn-outline-danger\"><i class=\"far fa-trash-alt\"></i></a></td>\r\n                            <td scope=\"col\"><a");
            BeginWriteAttribute("onclick", " onclick=\"", 1821, "\"", 1850, 3);
            WriteAttributeValue("", 1831, "hide(\'", 1831, 6, true);
#nullable restore
#line 46 "C:\Users\Georgios.Loulakis\Source\Repos\gloulakis\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Company\Company.cshtml"
WriteAttributeValue("", 1837, Company.Id, 1837, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1848, "\')", 1848, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\"><i class=\"far fa-eye-slash\"></i></a></td>\r\n\r\n                        </tr>\r\n                    </tbody>\r\n");
#nullable restore
#line 50 "C:\Users\Georgios.Loulakis\Source\Repos\gloulakis\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Company\Company.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n");
#nullable restore
#line 52 "C:\Users\Georgios.Loulakis\Source\Repos\gloulakis\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Company\Company.cshtml"
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
        window.location =""/Company/Edit/""+id
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



</script>
");
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
