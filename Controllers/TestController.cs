using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController: ControllerBase
    {        
        [HttpGet]
        public IActionResult GetTest()
        {
            return Ok("Ok");
        }

        [HttpGet("{id}")]
        public IActionResult GetByID([FromRoute] string id)
        {
            return Ok(id);
        }


        [HttpPost("{id}")]
        public IActionResult Post([FromBody] string id)
        {
            return Ok(id);
        }
    }
}
