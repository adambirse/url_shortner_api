using Microsoft.AspNetCore.Mvc;
using MyApp.Namespace;
namespace test;

public class HelloWorldControllerTest
{
    [Fact]
    public void TestHelloWorld()
    {
        HelloWorldController controller = new HelloWorldController();
        ActionResult<string> result = controller.GetHelloWorld();
        Assert.Equal("Hello Worsdsdld", result.Value);
    }
}