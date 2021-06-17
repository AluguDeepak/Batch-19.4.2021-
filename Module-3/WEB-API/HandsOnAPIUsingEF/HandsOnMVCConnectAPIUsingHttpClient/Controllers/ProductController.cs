using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnMVCConnectAPIUsingHttpClient.Services;
using HandsOnMVCConnectAPIUsingHttpClient.Models;
namespace HandsOnMVCConnectAPIUsingHttpClient.Controllers
{
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private IProductService _service = null;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [Route("GetAll")]
        public IActionResult Index()
        {
            List<Product> list = _service.GetProducts();
            return View(list);
        }
        [Route("GetById/{id}")]
        public IActionResult Details(int id)
        {
            Product product = _service.GetProduct(id);
            return View(product);
        }
        [Route("Add")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult Create(Product product)
        {
            _service.Add(product);
            return RedirectToAction("Index");
        }
        [Route("Edit/{id}")]
        public IActionResult Edit(int id)
        {
            Product product = _service.GetProduct(id);
            return View(product);
        }
        [HttpPost]
        [Route("Edit/{id}")]
        public IActionResult Edit(Product product)
        {
            try
            {
                _service.Update(product);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return View("Error", new ErrorViewModel());
            }
        }
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
