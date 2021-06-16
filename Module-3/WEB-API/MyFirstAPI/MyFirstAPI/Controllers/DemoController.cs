using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
      
        public IActionResult Get()
        {
            return Ok("Hello World");
        }
        [HttpGet("{name}")]
        public IActionResult Get(string name)
        {
            string msg = "Hi," + name;
            return Ok(msg);
        }
    }
}
