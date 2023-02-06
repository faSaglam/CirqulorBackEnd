using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CirqularWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialController : ControllerBase
    {
        private IMaterialService _metarialService;

        public MaterialController(IMaterialService metarialService)
        {
            _metarialService= metarialService;
        }
        [HttpGet("list")]
        public IActionResult GetAll()
        {
            var result = _metarialService.GetAll().ToList();
            return Ok(result);
        }
    }
}
