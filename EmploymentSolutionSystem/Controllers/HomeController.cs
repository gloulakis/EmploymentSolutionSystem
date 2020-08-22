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
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IJobListService jobListServices;


        public HomeController(IJobListService jobListServices)
        {
            this.jobListServices = jobListServices;
        }


        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                jobListServices.Delete(id);
            }
            return RedirectToAction("Advertisement");
        }

        [HttpGet]
        [Route("Home/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            var model = jobListServices.GetById(id);
            return View(model);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("Home/ApplyView/{id}")]
        public IActionResult ApplyView(int id)
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
        public IActionResult Create(JobList jobList, IFormFile files)
        {
            if (ModelState.IsValid)
            {
                if (files != null)
                {
                    if(files.Length > 0)
                    {
                        var fileName = Path.GetFileName(files.FileName);
                        var myUniqueFileName = Convert.ToString(Guid.NewGuid());
                        var fileExtension = Path.GetExtension(fileName);
                        var newFileName = string.Concat(myUniqueFileName, fileExtension);
                        var filepath = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwroot", "Images")).Root + $@"\{newFileName}";
                        using (FileStream fs = System.IO.File.Create(filepath))
                        {
                            files.CopyTo(fs);
                            fs.Flush();
                        }
                    }
                }
                jobListServices.Add(jobList);
            }
            else
            {
                return RedirectToAction("Create");
            }


            return RedirectToAction("Advertisement");
        }


        [HttpGet]
        public IActionResult Advertisement()
        {
            var model = jobListServices.GetAll();
            return View(model);
        }

        [AllowAnonymous]
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
