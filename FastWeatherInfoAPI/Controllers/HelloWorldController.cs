using Microsoft.AspNetCore.Mvc;

namespace FastWeatherInfoAPI.Controllers;

[ApiController]
[Route("api/hello-world")]
public class HelloWorldController : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult> Get() => Ok("Hello World!");
}