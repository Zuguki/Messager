using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Messager.Controllers;

[ApiController]
[Route("api/v1")]
public class TestController : ControllerBase
{
    [HttpGet]
    [Authorize]
    public async Task<IActionResult> GetAll()
    {
        return Ok(new[] {"123", "321"});
    }
}