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
    public class AdminController : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetEmployeeNames()
        {
            List<string> list = new List<string>() { "ROhan", "Jeson" };

            return Ok(list);
        }
        [HttpGet]
        [Route("Get/{id}")]
        public IActionResult EmployeeById(int id)
        {
            if (id != 0)
                return Ok("Suren");
            else
                return BadRequest("Invalid Id");
        }
        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult AddEmployee(object employee)
        {
            return Ok("Employee Added");
        }
        [HttpPost]
        [Route("AddProject")]
        public IActionResult AddProject(object project)
        {
            return Ok("Project Added");
        }
    }
}
