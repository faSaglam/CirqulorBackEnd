using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CirqularWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        public IFormService _formService;
        public FormController(IFormService formService) 
        {
            _formService = formService;
        }
        [HttpGet("list")]
        public IActionResult List()
        {
            var result = _formService.GetAll().ToList();
            return Ok(result);
        }
    }
}
