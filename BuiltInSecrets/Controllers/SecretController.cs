using Microsoft.AspNetCore.Mvc;

namespace BuiltInSecrets.Controllers;

[ApiController]
[Route("[controller]")]
public class SecretController : ControllerBase
{

    public SecretController()
    {
    }

    [HttpGet(Name = "GetSecret")]
    public string Get([FromServices] IConfiguration configuration)
    {
        return configuration["db"];
    }
}
