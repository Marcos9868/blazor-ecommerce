using BlazorEcommerce.Server.Data;
using Microsoft.AspNetCore.Mvc;
using BlazorEcommerce.Server.Contracts;

namespace BlazorEcommerce.Server.Controllers
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
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Product))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("/products")]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProducts()
        {
            var result = await _productService.GetProducts();
            if (result is null)
                return BadRequest("Unable to list products");
                
            return Ok(result);
        }
    }
}