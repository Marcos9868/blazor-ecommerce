using BlazorEcommerce.Server.Data;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductController(DataContext context)
        {
            _context = context;    
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Product))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("/products")]
        public async Task<IActionResult> GetProducts()
        {
            var Products = await _context.Products.ToListAsync();
            if (Products is null)
                return BadRequest("Unable to list products");
                
            return Ok(Products);
        }
    }
}