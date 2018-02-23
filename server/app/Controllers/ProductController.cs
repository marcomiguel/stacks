using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using app.Models;
using app.Services;

namespace app.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        [Route("api/products")]
        public async Task<IEnumerable<ProductModel>> Get()
        {
            return await _productService.GetProducts();
        }
        [HttpGet]
        [Route("api/test")]
        public string Test()
        {
            return "hiii";
        }
    }
}