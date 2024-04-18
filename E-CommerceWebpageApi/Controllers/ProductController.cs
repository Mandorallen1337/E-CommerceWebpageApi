using E_CommerceWebpageApi.Models;
using E_CommerceWebpageApi.Sevices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceWebpageApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ProductService productService;
        public ProductController(ProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public List<Product> GetProducts()
        {
            return productService.GetProducts();
        }

        [HttpPost("create")]
        public IActionResult CreateProduct(Product product)
        {
            productService.CreateProduct(product);
            return Ok();
        }

        [HttpDelete("delete")]
        public IActionResult DeleteProduct(int id)
        {
            productService.DeleteProduct(id);
            return Ok();
        }

        [HttpPut("update")]
        public IActionResult UpdateProduct(Product product)
        {
            productService.UpdateProduct(product);
            return Ok();
        }
    }
}
