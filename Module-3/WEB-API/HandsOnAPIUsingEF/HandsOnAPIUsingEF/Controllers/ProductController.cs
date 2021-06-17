using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIUsingEF.Entities;
using HandsOnAPIUsingEF.Repositories;
namespace HandsOnAPIUsingEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductRepository _repository = null;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            List<Product> products = _repository.GetProducts();
            return Ok(products);
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                Product product = _repository.GetProduct(id);
                if (product != null)
                    return Ok(product);
                else
                    return Content("Invalid Id");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult AddProduct(Product product)
        {
            try
            {
                _repository.Add(product);
                return Ok();
            }
            catch (Exception ex)
            {

                return Content(ex.InnerException.Message);
            }
        }
        [HttpPut]
        [Route("Edit")]
        public IActionResult UpdateProduct(Product product)
        {
            try
            {
                _repository.Update(product);
                return Ok();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                _repository.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }
        }


    }
}
