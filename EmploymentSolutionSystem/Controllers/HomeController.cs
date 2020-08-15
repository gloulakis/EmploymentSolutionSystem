using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EmploymentSolutionSystem.Models;
using EmploymentSolutionSystem.Services;
using EmploymentSolutionSystem.Domain.Models;

namespace EmploymentSolutionSystem.Controllers
{

    public class HomeController : Controller
    {
        private readonly IJobListService jobListServices;


        public HomeController(IJobListService jobListServices)
        {
            this.jobListServices = jobListServices;
        }


        public IActionResult Index()
        {
            return View();
        }

       
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
