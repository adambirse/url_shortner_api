using Microsoft.AspNetCore.Mvc;
using MyApp.Namespace;
using Moq;
using services.todo;
namespace test;

public class NetworkCallControllerTest
{
    [Fact]
    public async Task TestSucess()
    {
        var mockTodoService = new Mock<ITodoService>();
        Todo[] todos = new Todo[] { new Todo { Title = "Hello World" } };
        mockTodoService.Setup(x => x.GetUserTodosAsync()).ReturnsAsync(todos);

        NetworkCallController controller = new NetworkCallController(mockTodoService.Object);
        ActionResult<Todo[]> result = await controller.GetNetworkCall();

        Assert.NotNull(result);  // Ensure the ActionResult is not null

        // Ensure the response has a successful status code
        Assert.IsType<OkObjectResult>(result.Result);

        var okResult = result.Result as OkObjectResult;
        Assert.NotNull(okResult);  // Ensure it's an OkObjectResult

        Assert.NotNull(okResult.Value);

        var todosResult = okResult.Value as Todo[];
        Assert.NotNull(todosResult);
        Assert.Single(todosResult);  // Ensure there's exactly one Todo

        Assert.Equal("Hello World", todosResult[0].Title);  // Validate the title of the Todo
    }

    [Fact]
    public async Task TestServiceFailure()
    {
        var mockTodoService = new Mock<ITodoService>();
        mockTodoService.Setup(x => x.GetUserTodosAsync()).ThrowsAsync(new Exception("Service failure"));

        NetworkCallController controller = new NetworkCallController(mockTodoService.Object);
        ActionResult<Todo[]> result = await controller.GetNetworkCall();

        Assert.NotNull(result);  // Ensure the ActionResult is not null

        // Ensure the response has a successful status code
        Assert.IsType<ObjectResult>(result.Result);

        var objectResult = result.Result as ObjectResult;
        Assert.NotNull(objectResult);  // Ensure it's an OkObjectResult

        Assert.Equal(500, objectResult.StatusCode);  // Check if status code is 500

        // Verify the error message contains the expected exception message
        Assert.Equal("Internal server error: Service failure", objectResult.Value);


    }
}