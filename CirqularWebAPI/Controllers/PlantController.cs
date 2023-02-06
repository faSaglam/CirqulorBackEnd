using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CirqularWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantController : ControllerBase
    {
        private  IPlantService _plantService;
        public PlantController(IPlantService plantService)
        {
            _plantService = plantService;
        }

        [HttpGet("list")]
        public IActionResult List()
        {
            var result = _plantService.GetAll();
            return Ok(result);
        }
    }
}
