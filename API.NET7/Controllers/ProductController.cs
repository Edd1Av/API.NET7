using API.NET7.Entitys;
using API.NET7.Models;
using API.NET7.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.NET7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            List<Product> products = _productService.GetProducts();
            return Ok(products);

        }

        [HttpPost]
        public IActionResult PostProduct(ProductModel product) { 
            _productService.CreateProduct(product);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            _productService.DeleteProduct(id);
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetProduct(int id)
        {
            Product product = _productService.GetProduct(id);
            return Ok(product);

        }

        [HttpPut]
        public IActionResult PutProduct(ProductModel product) 
        {  
            _productService.UpdateProduct(product);
            return Ok();
        }
    }
}
