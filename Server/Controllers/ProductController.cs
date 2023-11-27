using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
        {
            new Product
            {
                IdProduct = 1,
                Title = "Black Cavendish Tobacco",
                Description = "A smoothy and sweetness tobacco",
                Image_Url = "",
                Price = 9.99m
            },
            new Product
            {
                IdProduct = 2,
                Title = "1984 - George Orhwell",
                Description = "This books tells about comunism destroy our world",
                Image_Url = "",
                Price = 19.99m
            },
            new Product
            {
                IdProduct = 3,
                Title = "SmartWatch",
                Description = "SmartWatch to monitore your heartbeats",
                Image_Url = "",
                Price = 29.99m
            }
        };

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Product))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Route("/products")]
        public async Task<IActionResult> GetProducts()
        {
            if (Products is null)
                return BadRequest("Unable to list products");
                
            return Ok(Products);
        }
    }
}