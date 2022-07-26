using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TforT.Models;
using TforT.Services;

namespace TforT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        ProductService _productService;
        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        // GET: api/<productController>
        [HttpGet]
        public List<Product> Get()
        {
            var result = _productService.Getproduct();
            return result;
        }

        // GET api/<productController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            var result = _productService.Getproduct(id);
            return result;
        }

        // POST api/<productController>
        [HttpPost]
        public bool Post([FromBody] Product product)
        {
            var result = _productService.add(product);
            return result;
        }

        // PUT api/<productController>/5
        [HttpPut("{id}")]
        public bool Put([FromBody] Product product)
        {
            var result = _productService.Edit(product);
            return result;
        }

        // DELETE api/<productController>/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            var result = _productService.Delete(id);
            return result;
        }
    }
}
