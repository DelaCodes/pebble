using Microsoft.AspNetCore.Mvc;

namespace Pebble.WebApi.Controllers;

[ApiController]
[Route("/")]
public class HelloWorldController : ControllerBase
{
    [HttpGet]
    public string HelloWorld()
    {
        return "Hello World";
    }
}