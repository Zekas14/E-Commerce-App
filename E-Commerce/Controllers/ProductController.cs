using Core.Entities;
using Core.Interfaces;
using Infrastruct.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(IProductRepository productRepository) : ControllerBase
    {
        private readonly IProductRepository productRepository=productRepository;
        [HttpGet("GetProducts")]
        public  async Task<IActionResult> GetProducts()
        {
            var products = await productRepository.GetAllProductsAsync();
            return Ok(products);
        }
        [HttpGet("GetProductById")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await productRepository.GetProductsByIdAsync(id);
            return Ok(product) ;
        }
    }
}
