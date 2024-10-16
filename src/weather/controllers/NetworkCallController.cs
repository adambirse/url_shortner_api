using Microsoft.AspNetCore.Mvc;
using services.todo;

namespace MyApp.Namespace
{
    [Route("api/networkCall")]
    [ApiController]
    public class NetworkCallController : ControllerBase
    {

        private readonly ITodoService todoService;

        public NetworkCallController(ITodoService todoService)
        {
            this.todoService = todoService;
        }
        [HttpGet]
        public async Task<ActionResult<Todo>> GetNetworkCall()
        {
            try
            {
                Todo[] todos = await todoService.GetUserTodosAsync();
                return Ok(todos);
            }
            catch (Exception ex)
            {
                // Handle any errors appropriately
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
