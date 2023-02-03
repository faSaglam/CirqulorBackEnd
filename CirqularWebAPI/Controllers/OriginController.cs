using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CirqularWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OriginController : ControllerBase
    {
        public IOriginService _originService;
        public OriginController(IOriginService originService)
        {
            _originService = originService;
        }
        [HttpGet("list")]
        public IActionResult List()
        {
            var result = _originService.GetAll().ToList();
            return Ok(result);
        }
    }
}
