using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CirqularWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("List")]
        public IActionResult List(int SubcategoryID)
        {
            var result = _productService.GetListBySub(SubcategoryID).ToList();
            return Ok(result);
        }
    }
}
