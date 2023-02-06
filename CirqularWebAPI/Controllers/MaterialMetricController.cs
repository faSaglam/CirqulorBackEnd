using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CirqularWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialMetricController : ControllerBase
    {
        private  IMaterialMetricService _materialMetricService;

        public MaterialMetricController(IMaterialMetricService materialMetricService)
        {
            _materialMetricService = materialMetricService;
        }
        [HttpGet("{id:int}")]
        public IActionResult GetByID(int id) 
        {
            var result = _materialMetricService.GetSingleByID(id);
            return Ok(result);
        }
    }
}
