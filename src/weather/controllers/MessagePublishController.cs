using Microsoft.AspNetCore.Mvc;
using MassTransit;
using messaging;
namespace MyApp.Namespace
{
    [Route("api/publish")]
    [ApiController]
    public class MessagePublishController : ControllerBase
    {


        readonly IBus _bus;

        public MessagePublishController(IBus bus)
        {
            _bus = bus;
        }

        [HttpPost]
        public async Task<ActionResult<string>> Publish()
        {
            await _bus.Publish(new Message2 { Text = "I was published as a result of the controller action" });
            return "Hello World";
        }
    }
}
