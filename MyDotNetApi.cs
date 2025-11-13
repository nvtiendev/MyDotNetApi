using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyDotNetApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyDotNetApi : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() => Ok(new { message = "Hello World!" });

        [HttpGet("{name}")]
        public IActionResult Get(string name) => Ok(new { message = $"Hello {name}!" });
    }
}
