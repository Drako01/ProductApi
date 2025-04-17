using Microsoft.AspNetCore.Mvc;
using ProductApi.Models;
using ProductApi.Services;

namespace ProductApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _productService.GetAll();
            return Ok(products);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var product = _productService.GetById(id);
            return product is null ? NotFound() : Ok(product);
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            var created = _productService.Add(product);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id, Product product)
        {
            product.Id = id;
            return _productService.Update(product) ? NoContent() : NotFound();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            return _productService.Delete(id) ? NoContent() : NotFound();
        }
    }
}
