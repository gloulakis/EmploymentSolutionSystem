using AutoMapper;
using EmploymentSolutionSystem.Domain.Models;
using EmploymentSolutionSystem.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmploymentSolutionSystem.Controllers
{
    [Authorize]
    public class AdvertisementController:Controller
    {
        private readonly IJobListService jobListServices;

        public AdvertisementController(IJobListService jobListServices)
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
        [Route("Advertisement/Edit/{id}")]
        public IActionResult Edit(int id)
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

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Create(JobList jobList)
        {
            if (ModelState.IsValid)
            {
               
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

 

    }
}
