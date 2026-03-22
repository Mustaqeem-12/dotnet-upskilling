using Microsoft.AspNetCore.Mvc;
using LuLuMall.Models;
using LuLuMall.Services;

namespace LuLuMall.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var data = _service.GetProducts();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            product.TotalPrice = product.Price + product.Gst;

            _service.AddProduct(product);
            return RedirectToAction("Index");
        }
    }
}
