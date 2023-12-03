using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class ProductController : Controller
    {
        private readonly WebmvcContext _DbContext;

        public ProductController(WebmvcContext dbContext)
        {
            this._DbContext = dbContext;
        }

        public IActionResult Index()
        {
            var products = this._DbContext.Products.ToList();
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var product = _DbContext.Products.Find(id);

            if (product == null)
            {
                return NotFound();
            }

            _DbContext.Products.Remove(product);
            _DbContext.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateProduct([FromBody] Product updatedProduct)
        {
            if (ModelState.IsValid)
            {
                var existingProduct = _DbContext.Products.Find(updatedProduct.Idproduct);

                if (existingProduct != null)
                {
                    existingProduct.Nameproduct = updatedProduct.Nameproduct;
                    existingProduct.Imageurl = updatedProduct.Imageurl;
                    existingProduct.Introduction = updatedProduct.Introduction;
                    existingProduct.Price = updatedProduct.Price;

                    _DbContext.SaveChanges();

                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            }

            return BadRequest(ModelState);
        }
    }
}
