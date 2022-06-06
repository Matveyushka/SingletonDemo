using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class PolySingletonController : ControllerBase
{
    private readonly IEnumerable<FakeSingleton> _polysingletons;

    public PolySingletonController(IEnumerable<FakeSingleton> polysingletons)
    {
        this._polysingletons = polysingletons;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_polysingletons.Select(polysingleton => polysingleton.Number));
    }
}