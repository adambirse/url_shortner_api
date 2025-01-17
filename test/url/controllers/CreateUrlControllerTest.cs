using Microsoft.AspNetCore.Mvc;
using src.url.controllers;
namespace test.url.controllers;
public class CreateUrlControllerTest
{
    [Fact]
    public void CreateUrl()
    {
        CreateUrlController controller = new CreateUrlController();
        ActionResult<string> result = controller.createUrl("https://www.google.com");
        Assert.Equal("https://www.google.com", result.Value);
    }
}