using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/hello")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> GetHelloWorld()
        {
            return "Hello World";
        }
    }
}
