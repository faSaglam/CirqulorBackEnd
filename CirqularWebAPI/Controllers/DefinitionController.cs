using Business.Abstract;
using Entities.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CirqularWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefinitionController : ControllerBase
    {
        public IDefinitionService _definitionService;
        public DefinitionController(IDefinitionService definitionService)
        {
            _definitionService = definitionService;
        }
        [HttpGet("list")]
        public IActionResult List()
        {
            var result = _definitionService.GetAll().ToList();
            return Ok(result);
        }
    }
}
