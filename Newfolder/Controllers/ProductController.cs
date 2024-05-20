using Microsoft.AspNetCore.Mvc;
using MIS.Entity;
using MIS.Service;

namespace MIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _productService;
        private readonly AuthorService _authorService;

        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult<List<Product>> GetAllProducts()
        {
            var products = _productService.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProductById(int id)
        {
            var product = _productService.GetProductById(id);

            if (product == null)
                return NotFound();

            return Ok(product);
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            Author author=_authorService.GetAuthorById(product.Authorobj.Id.Value);
            product.Authorobj=author;

            _productService.CreateProduct(product);
            return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product product)
        {
            

            var existingProduct = _productService.GetProductById(id);
            if (existingProduct == null)
                return NotFound();

            existingProduct.Name = product.Name ?? existingProduct.Name;
            existingProduct.Description = product.Description ?? existingProduct.Description;
            existingProduct.Category = product.Category ?? existingProduct.Category;
            existingProduct.Price = product.Price ?? existingProduct.Price;
            existingProduct.CreatedDate = product.CreatedDate ?? existingProduct.CreatedDate;
            existingProduct.totalQuantity = product.totalQuantity ?? existingProduct.totalQuantity;
            existingProduct.RemainingQuantity = product.RemainingQuantity ?? existingProduct.RemainingQuantity;
            existingProduct.SoldQuantity = product.SoldQuantity ?? existingProduct.SoldQuantity;


            _productService.UpdateProduct(existingProduct);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = _productService.GetProductById(id);
            if (product == null)
                return NotFound();

            _productService.DeleteProduct(product);
            return NoContent();
        }
        [HttpGet("search")]
        public IActionResult SearchProducts(string searchQuery)
        {
            if (string.IsNullOrEmpty(searchQuery))
            {
                return BadRequest("Search query is required.");
            }

            List<Product> searchResult = _productService.SearchProductsByName(searchQuery);

            return Ok(searchResult);
        }
    }
}
