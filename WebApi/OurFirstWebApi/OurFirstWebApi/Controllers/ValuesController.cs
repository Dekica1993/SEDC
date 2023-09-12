using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OurFirstWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {  
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpPost("Post")]
        public IActionResult Post()
        {
            return BadRequest();
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }

        
        

    }
}
