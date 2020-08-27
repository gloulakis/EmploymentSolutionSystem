using EmploymentSolutionSystem.Domain.Models;
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
        public IActionResult Company()
        {
            var model = companyService.GetAll();
            return View(model);
        }

        [HttpGet]
        [Route("Company/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            var model = companyService.GetById(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult SaveEdit(Company company)
        {
            if (ModelState.IsValid)
            {
                companyService.Edit(company);
            }
            return RedirectToAction("Company");
        }

        [HttpGet]
        public IActionResult CreateCompany()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCompany(Company company)
        {
            if (ModelState.IsValid)
            {
                companyService.Add(company);
            }
            else
            {
                return RedirectToAction("CreateCompany");
            }
            return RedirectToAction("Company");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
