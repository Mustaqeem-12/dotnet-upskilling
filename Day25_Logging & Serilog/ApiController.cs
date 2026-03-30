using LuLuMall.Models;
using LuLuMall.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace LuLuMall.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsApiController : ControllerBase
    {
        private readonly IProductService _service;
        private readonly ILogger<ProductsApiController> _logger;

        public ProductsApiController(IProductService service, ILogger<ProductsApiController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public async Task <IActionResult> GetProducts(string? search,int page =1, int pageSize = 5, string? sort = null)
        {
            _logger.LogInformation("get products api called");
            var data = await _service.GetProducts(search, page, pageSize, sort);
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
            _logger.LogInformation("Create product called");
            product.TotalPrice = product.Price + (product.Price * product.Gst / 100);
            _service.AddProduct(product);
            _logger.LogInformation("product created Successfully");
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
