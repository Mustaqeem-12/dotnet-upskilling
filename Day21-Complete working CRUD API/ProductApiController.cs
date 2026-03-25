using LuLuMall.Models;
using LuLuMall.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LuLuMall.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsApiController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductsApiController(IProductService service)
        {
            _service = service;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var data = _service.GetProducts();
            return Ok(data);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var data = _service.GetProductById(id);

            if (data == null)
                return NotFound();
            return Ok(data);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            product.TotalPrice = product.Price + (product.Price * product.Gst / 100);
            _service.AddProduct(product);
            return Ok(product);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Product product)
        {
            if (id <= 0)
                return BadRequest();

            var existingProduct = _service.GetProductById(id);

            if (existingProduct == null)
                return NotFound();

            // update fields
            existingProduct.ItemName = product.ItemName;
            existingProduct.Quantity = product.Quantity;
            existingProduct.Price = product.Price;
            existingProduct.Gst = product.Gst;

            // recalculate total
            existingProduct.TotalPrice = product.Price + (product.Price * product.Gst / 100);

            _service.UpdateProduct(existingProduct);

            return Ok(existingProduct);
        }
        

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.DeleteProduct(id);
            return Ok("Deleted Successfully");
        }
    }
}
