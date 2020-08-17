#pragma checksum "C:\Users\Georgios.Loulakis\Documents\MyProject\MyProject\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\ClientView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a95a5ea5c151626042eebb5cdaffe6833d43fce2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ClientView), @"mvc.1.0.view", @"/Views/Home/ClientView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a95a5ea5c151626042eebb5cdaffe6833d43fce2", @"/Views/Home/ClientView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2737ee6aec5ec161a71b3407c043c6c8682691b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ClientView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<JobList>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Georgios.Loulakis\Documents\MyProject\MyProject\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\ClientView.cshtml"
  
    ViewData["Title"] = "Find New Job";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"form-row\">\r\n    <div class=\"col-6\">\r\n        <h4 class=\"text-info\">Apply now!</h4>\r\n    </div>\r\n</div>\r\n<br />\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Georgios.Loulakis\Documents\MyProject\MyProject\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\ClientView.cshtml"
  
    if (Model == null)
    {
        for (int i = 0; i < 10; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""card shadow"" style=""
                    width: 18rem;
                    height: 20rem;
                    overflow: hidden;
                    float: left;
                    border: 2px solid;
                    margin: 10px;"">
                <img src=""/Images/Home/30.jpg"" class=""card-img-top"" alt=""..."">
                <div class=""card-body"">
                    <h5 class=""card-title font-weight-bold"">Empty</h5>
                    <h5 hidden class=""card-title font-weight-bold"">Empty</h5>
                    <p class=""card-text font-weight-bold"">Position:Empty</p>
                    <p>Salary:Empty</p>
                    <a data-toggle=""modal"" data-target=""#exampleModalScrollable"" class=""btn btn-outline-dark"">More</a>
                </div>
            </div>
");
#nullable restore
#line 35 "C:\Users\Georgios.Loulakis\Documents\MyProject\MyProject\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\ClientView.cshtml"
        }
    }
    else
    {
        foreach (var job in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""card shadow"" style=""
                    width: 18rem;
                    height: 20rem;
                    overflow: hidden;
                    float: left;
                    border: 2px solid;
                    margin: 10px;"">
                <img src=""https://assets.jobs.bg/assets/job_cover/2020-04-01/s_348d6ed795da73a6f839cab8a9046c87.png"" class=""card-img-top"" alt=""..."">
                <div class=""card-body"">
                    <h5 class=""card-title font-weight-bold"">");
#nullable restore
#line 50 "C:\Users\Georgios.Loulakis\Documents\MyProject\MyProject\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\ClientView.cshtml"
                                                       Write(job.JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h5 hidden class=\"card-title font-weight-bold\">");
#nullable restore
#line 51 "C:\Users\Georgios.Loulakis\Documents\MyProject\MyProject\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\ClientView.cshtml"
                                                              Write(job.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text font-weight-bold\">Position:");
#nullable restore
#line 52 "C:\Users\Georgios.Loulakis\Documents\MyProject\MyProject\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\ClientView.cshtml"
                                                              Write(job.JobPosition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>Salary:");
#nullable restore
#line 53 "C:\Users\Georgios.Loulakis\Documents\MyProject\MyProject\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\ClientView.cshtml"
                         Write(job.JobSalary);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    <a data-toggle=""modal"" data-target=""#exampleModalScrollable"" class=""btn btn-outline-dark"">More</a>
                    <div class=""modal fade"" id=""exampleModalScrollable"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalScrollableTitle"" aria-hidden=""true"">
                        <div class=""modal-dialog modal-dialog-scrollable"" role=""document"">
                            <div class=""modal-content"">
                                <div class=""modal-header"">
                                    <h5 class=""modal-title"" id=""exampleModalScrollableTitle"">");
#nullable restore
#line 59 "C:\Users\Georgios.Loulakis\Documents\MyProject\MyProject\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\ClientView.cshtml"
                                                                                        Write(job.JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    <h5 hidden class=\"modal-title\" id=\"exampleModalScrollableTitle\">");
#nullable restore
#line 60 "C:\Users\Georgios.Loulakis\Documents\MyProject\MyProject\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\ClientView.cshtml"
                                                                                               Write(job.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                        <span aria-hidden=""true"">&times;</span>
                                    </button>
                                </div>
                                <div class=""modal-body"">
                                    ");
#nullable restore
#line 66 "C:\Users\Georgios.Loulakis\Documents\MyProject\MyProject\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\ClientView.cshtml"
                               Write(job.JobDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                                <div class=""modal-footer"">
                                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                    <button type=""button"" class=""btn btn-primary"">Apply</button>
                                    <br />
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
");
#nullable restore
#line 79 "C:\Users\Georgios.Loulakis\Documents\MyProject\MyProject\EmploymentSolutionSystem\EmploymentSolutionSystem\Views\Home\ClientView.cshtml"


        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
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
