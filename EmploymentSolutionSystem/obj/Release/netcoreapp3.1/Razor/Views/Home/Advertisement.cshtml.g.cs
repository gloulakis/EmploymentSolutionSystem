#pragma checksum "C:\Users\Georgios.Loulakis\Documents\MyProject\MyProject\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\Advertisement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5da3377b4915851c96f5a5d33cdff1ae04edfd5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Advertisement), @"mvc.1.0.view", @"/Views/Home/Advertisement.cshtml")]
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
#line 1 "C:\Users\Georgios.Loulakis\Documents\MyProject\MyProject\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\_ViewImports.cshtml"
using EmploymentSolutionSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Georgios.Loulakis\Documents\MyProject\MyProject\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\_ViewImports.cshtml"
using EmploymentSolutionSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Georgios.Loulakis\Documents\MyProject\MyProject\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\_ViewImports.cshtml"
using EmploymentSolutionSystem.Domain.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5da3377b4915851c96f5a5d33cdff1ae04edfd5e", @"/Views/Home/Advertisement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2737ee6aec5ec161a71b3407c043c6c8682691b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Advertisement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<JobList>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ClientView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#exampleModal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "/", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Georgios.Loulakis\Documents\MyProject\MyProject\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\Advertisement.cshtml"
  
    ViewData["Title"] = "Job Advertisements";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"border border-white\">\r\n\r\n    <div class=\"form-row\">\r\n        <div class=\"col-6\">\r\n            <h4 class=\"text-info\">New Advertisement!</h4>\r\n        </div>\r\n        <div class=\"col-6 text-right\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5da3377b4915851c96f5a5d33cdff1ae04edfd5e6395", async() => {
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
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5da3377b4915851c96f5a5d33cdff1ae04edfd5e7645", async() => {
                WriteLiteral("Client View");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
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
#line 19 "C:\Users\Georgios.Loulakis\Documents\MyProject\MyProject\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\Advertisement.cshtml"
         if (Model == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>No Job exists. Please Create a new Job Advertisement!</p>\r\n");
#nullable restore
#line 22 "C:\Users\Georgios.Loulakis\Documents\MyProject\MyProject\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\Advertisement.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table"">
                <thead class=""thead-dark"">
                    <tr>
                        <th scope=""col"">Title</th>
                        <th scope=""col"">Position</th>
                        <th scope=""col"">Salary</th>
                        <th scope=""col""></th>
                        <th scope=""col""></th>
                        <th scope=""col""></th>
                    </tr>
                </thead>
");
#nullable restore
#line 36 "C:\Users\Georgios.Loulakis\Documents\MyProject\MyProject\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\Advertisement.cshtml"
                 foreach (var job in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tbody>\r\n                        <tr>\r\n\r\n                            <td>");
#nullable restore
#line 41 "C:\Users\Georgios.Loulakis\Documents\MyProject\MyProject\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\Advertisement.cshtml"
                           Write(Html.DisplayFor(m => job.JobTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 42 "C:\Users\Georgios.Loulakis\Documents\MyProject\MyProject\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\Advertisement.cshtml"
                           Write(Html.DisplayFor(m => job.JobPosition));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 43 "C:\Users\Georgios.Loulakis\Documents\MyProject\MyProject\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\Advertisement.cshtml"
                           Write(Html.DisplayFor(m => job.JobSalary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            \r\n                            <td scope=\"col\"><a");
            BeginWriteAttribute("onclick", " onclick=\"", 1519, "\"", 1544, 3);
            WriteAttributeValue("", 1529, "edit(\'", 1529, 6, true);
#nullable restore
#line 45 "C:\Users\Georgios.Loulakis\Documents\MyProject\MyProject\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\Advertisement.cshtml"
WriteAttributeValue("", 1535, job.Id, 1535, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1542, "\')", 1542, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-warning\"><i class=\"far fa-edit\"></i></a></td>\r\n                            <td scope=\"col\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5da3377b4915851c96f5a5d33cdff1ae04edfd5e12313", async() => {
                WriteLiteral("<i class=\"far fa-trash-alt\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1672, "GetJobtodelete(\'", 1672, 16, true);
#nullable restore
#line 46 "C:\Users\Georgios.Loulakis\Documents\MyProject\MyProject\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\Advertisement.cshtml"
AddHtmlAttributeValue("", 1688, job.Id, 1688, 7, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1695, "\',\'", 1695, 3, true);
#nullable restore
#line 46 "C:\Users\Georgios.Loulakis\Documents\MyProject\MyProject\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\Advertisement.cshtml"
AddHtmlAttributeValue("", 1698, job.JobTitle, 1698, 13, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1711, "\')", 1711, 2, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                            <td scope=\"col\"><a");
            BeginWriteAttribute("onclick", " onclick=\"", 1898, "\"", 1923, 3);
            WriteAttributeValue("", 1908, "hide(\'", 1908, 6, true);
#nullable restore
#line 47 "C:\Users\Georgios.Loulakis\Documents\MyProject\MyProject\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\Advertisement.cshtml"
WriteAttributeValue("", 1914, job.Id, 1914, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1921, "\')", 1921, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\"><i class=\"far fa-eye-slash\"></i></a></td>\r\n                         \r\n                        </tr>\r\n                    </tbody>\r\n");
#nullable restore
#line 51 "C:\Users\Georgios.Loulakis\Documents\MyProject\MyProject\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\Advertisement.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n");
#nullable restore
#line 53 "C:\Users\Georgios.Loulakis\Documents\MyProject\MyProject\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\Advertisement.cshtml"
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
                    <p>Are you sure - <span id=""JobToDeleteTitle""></span><span hidden id=""JobToDeleteID""></span></p>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button onclick=""DeleteJob()"" type=""button"" class=""btn btn-primary"">Delete</b");
            WriteLiteral(@"utton>
                </div>
        </div>
    </div>
        </div>



<script>
    function edit(id) {
        window.location =""/Home/Edit/""+id
    }

    function GetJobtodelete(id, Title) {
        var $Title = $(""#JobToDeleteTitle"");
        var $id = $(""#JobToDeleteID"");

        $Title.html(Title);
        $id.html(id);
    }

    function DeleteJob() {
        var $id = $(""#JobToDeleteID"").html();
        window.location = ""/Home/Delete/""+ $id;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<JobList>> Html { get; private set; }
    }
}
#pragma warning restore 1591