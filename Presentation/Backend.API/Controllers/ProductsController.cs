using Backend.Application.Abstraction;
using Backend.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult GetAction()
        {
            var products = _productService.GetProducts();   
            return Ok(products);
        }
        [HttpGet("id")]
        public IActionResult GetProductById(string id) {
            var product = _productService.GetProductById(id);
            return Ok(product);
        }
    }
}
