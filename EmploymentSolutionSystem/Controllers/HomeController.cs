using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EmploymentSolutionSystem.Models;
using EmploymentSolutionSystem.Services;
using EmploymentSolutionSystem.Domain.Models;
using Microsoft.AspNetCore.Authorization;

namespace EmploymentSolutionSystem.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IJobListService jobListServices;

       
        public HomeController(IJobListService jobListServices)
        {
            this.jobListServices = jobListServices;
        }

     
        public IActionResult Delete( int id)
        {
            if (ModelState.IsValid)
            {
                jobListServices.Delete(id);

            }
            return RedirectToAction("Advertisement");
        }

       
        [HttpGet]
        [Route("Home/Edit/{id}")]
        public IActionResult Edit (int id)
        {
            var model = jobListServices.GetById(id);
            return View(model);
        }

       
        [HttpPost]
        public IActionResult SaveEdit(JobList jobList)
        {
            if (ModelState.IsValid)
            {
                jobListServices.Edit(jobList);
            }
            return RedirectToAction("Advertisement");
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult ClientView()
        {
            var model = jobListServices.GetAll();
            return View(model);
        }

      
        [HttpGet]
        public IActionResult Create()
        {
            
            return View();
        }

      
        [HttpPost]
        public IActionResult Create(JobList jobList)
        {
            jobListServices.Add(jobList);
            return RedirectToAction("Advertisement");
        }

 
        [HttpGet]
        public IActionResult Advertisement()
        {
            var model = jobListServices.GetAll();
            return View(model);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
