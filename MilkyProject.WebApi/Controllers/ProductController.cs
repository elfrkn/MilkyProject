using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MilkProject.BusinessLayer.Abstract;
using MilkProject.EntityLayer.Concrete;

namespace MilkyProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult ProductList()
        {
            var values = _productService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]

        public IActionResult CreateProduct(Product product)
        {
            _productService.TInsert(product);
            return Ok("Ürün başarıyla eklendi.");
        }

        [HttpDelete]

        public IActionResult DeleteProduct(int id)
        {
            _productService.TDelete(id);
            return Ok("Ürün başarıyla silindi");
        }

        [HttpGet("GetProduct")]

        public IActionResult GetProduct(int id)
        {
            var value = _productService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult PutProduct(Product product)
        {
            _productService.TUpdate(product);
            return Ok("Ürün başarıyla güncellendi.");

        }
        [HttpGet("GetProductWithCategory")]
        public IActionResult GetProductWithCategory()
        {
            var values=_productService.TGetProductsWithCategory();
            return Ok(values);
        }
    }
}
