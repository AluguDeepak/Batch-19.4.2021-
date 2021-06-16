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
        [HttpPost]
        public IActionResult POST(object item)
        {
            return Ok("Item Added");
        }
        [HttpPut]
        public IActionResult PUT(object item)
        {
            return Ok("Item Updated");
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("Delete Item");
        }
    }
}
