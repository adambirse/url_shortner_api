using Microsoft.AspNetCore.Mvc;

namespace src.url.controllers;
[Route("api/url/create")]
[ApiController]
public class CreateUrlController : ControllerBase
{
    [HttpPost]
    public ActionResult<string> createUrl(string url)
    {
        return url;
    }
}
