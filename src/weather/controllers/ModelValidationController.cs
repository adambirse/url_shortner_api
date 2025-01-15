using Microsoft.AspNetCore.Mvc;
[Route("api/modelvalidation")]
[ApiController]
public class ModelValidationController : ControllerBase
{
    [HttpPost]
    public ActionResult<string> validateModel(ExampleModel model)
    {
        if (ModelState.IsValid)
        {
            Console.WriteLine("Model is valid");
            return Ok("Model is valid");
        }
        else
        {
            Console.WriteLine("Model is invalid");
            return BadRequest(ModelState);
        }
    }
}
