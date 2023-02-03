using Business.Abstract;
using DataAccess.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CirqularWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxonomyController : ControllerBase
    {
   
        private ITaxonomyService _taxonomyService;
        public TaxonomyController(ITaxonomyService taxonomyService )
        {
            _taxonomyService = taxonomyService;
       
        }
      
        [HttpGet("list")]
        public IActionResult GetList()
        {
            var result = _taxonomyService.GetAll().ToList();

            return Ok(result);
        }
        //[HttpGet("listwithsubs")]
        //public IActionResult  CategorySubs() 
        //{
        
          
        //}

    }
}
