using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EmploymentSolutionSystem.Models;
using Microsoft.AspNetCore.Routing;
using EmploymentSolutionSystem.Data;
using EmploymentSolutionSystem.Domain.Models;
using Microsoft.EntityFrameworkCore;
using EmploymentSolutionSystem.Domain.Services;

namespace EmploymentSolutionSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IJobListServices joblist;

        public HomeController(IJobListServices joblist)
        {
            this.joblist = joblist;
        }

        public IActionResult Index()
        {
            return View();
        }
       
        [HttpGet]
        public IActionResult Advertisement()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
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
