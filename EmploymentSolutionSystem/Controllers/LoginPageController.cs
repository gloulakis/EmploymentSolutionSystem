using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmploymentSolutionSystem.Controllers
{
    public class LoginPageController:Controller
    {
        [HttpGet]
        public IActionResult PageLogin()
        {
            return View();
        }
    }
}
