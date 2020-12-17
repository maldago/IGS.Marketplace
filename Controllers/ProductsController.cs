using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IntelligentGrowthSolutions.Marketplace.Models;
using System.Threading;
using IntelligentGrowthSolutions.Marketplace.Services;

namespace IntelligentGrowthSolutions.Marketplace.Controllers
{
    [Route("v1")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/Products
        [HttpGet("products")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts(CancellationToken cancellationToken = default)
        {
            return Ok(await _productService.GetAllProducts(cancellationToken));
        }

        // GET: api/Products/5
        [HttpGet("product/{id}")]
        public async Task<ActionResult<Product>> GetProduct([FromRoute]int id, CancellationToken cancellationToken = default)
        {
            var product = await _productService.GetByProductId(id, cancellationToken);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        // PUT: v1/products/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("product/{id}")]
        public async Task<IActionResult> PutProduct(int id, [FromForm]Product product, CancellationToken cancellationToken = default)
        {
            var existing = await _productService.GetByProductId(id, cancellationToken);
            if (existing == null)
            {
                return NotFound();
            }

            if (!string.IsNullOrWhiteSpace(product.Name))
            {
                existing.Name = product.Name;
            }

            if (!string.IsNullOrWhiteSpace(product.Price))
            {
                existing.Price = product.Price;
            }

            var updatedProduct = await _productService.UpdateProduct(existing, cancellationToken);
            

            return Ok(updatedProduct);
        }

        // POST: v1/product
        [HttpPost("product")]
        public async Task<ActionResult<Product>> PostProduct([FromForm]Product product, CancellationToken cancellationToken = default)
        {
            if(string.IsNullOrWhiteSpace(product.Name))
            {
                return BadRequest("Name is required.");
            }

            if(string.IsNullOrWhiteSpace("product.Price"))
            {
                return BadRequest("Price is required.");
            }
            var newProduct = await _productService.AddProduct(product, cancellationToken);

            return Ok(newProduct);
        }

        // DELETE: api/Products/5
        [HttpDelete("product/{id}")]
        public async Task<ActionResult<Product>> DeleteProduct([FromRoute] int id, CancellationToken cancellationToken = default)
        {
            var product = await _productService.GetByProductId(id, cancellationToken);
            if (product == null)
            {
                return NotFound();
            }

            await _productService.DeleteProduct(id, cancellationToken);

            return Ok();
        }
    }
}
