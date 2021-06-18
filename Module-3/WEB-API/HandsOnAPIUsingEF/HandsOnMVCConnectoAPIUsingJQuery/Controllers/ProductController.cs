using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnMVCConnectoAPIUsingJQuery.Controllers
{
   [Route("[controller]")]
    public class ProductController : Controller
    {
        [Route("GetAll")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
