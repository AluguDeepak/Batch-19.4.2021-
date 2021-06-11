using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnMVCusingHelpersandModelValidation.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Create1() //design the template using stronly typed helpers
        {
            return View();
        }
        public IActionResult Create2() //design the template using tag helpers
        {
            return View();
        }
    }
}
