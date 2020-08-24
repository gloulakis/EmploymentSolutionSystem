using EmploymentSolutionSystem.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmploymentSolutionSystem.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService companyService;

        public CompanyController (ICompanyService companyService)
        {
            this.companyService = companyService;
        }

        [HttpGet]
        public IActionResult Companies()
        {
            var model = companyService.GetAll();
            return View(model);
        }

        [HttpPost]
        public IActionResult CreateCompany(Domain.Models.Company company)
        {
            if (ModelState.IsValid)
            {

                companyService.Add(company);
            }
            else
            {
                return RedirectToAction("CreateCompany");
            }


            return RedirectToAction("Companies");
        }





        public IActionResult Index()
        {
            return View();
        }
    }
}
