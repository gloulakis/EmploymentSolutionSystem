using EmploymentSolutionSystem.Domain.Models;
using EmploymentSolutionSystem.Models;
using EmploymentSolutionSystem.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using System;
using System.Diagnostics;
using System.IO;

namespace EmploymentSolutionSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IJobListService jobListServices;
      


        public HomeController(IJobListService jobListServices)
        {
            this.jobListServices = jobListServices;
    
        }

        [HttpGet]
        [Route("Home/ApplyView/{id}")]
        public IActionResult ApplyView(int id)
        {
            var model = jobListServices.GetById(id);
            return View(model);
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ApplyView()
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
