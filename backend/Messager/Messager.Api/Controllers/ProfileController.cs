using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Messager.Controllers;

[ApiController]
[Route("api/v1/profile")]
public class ProfileController : ControllerBase
{
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetUserAsync([FromRoute] Guid id)
    {
        return Ok();
    }

    [HttpPost("updatePicture")]
    public async Task<IActionResult> UpdatePictureAsync([FromForm] IFormFile file)
    {
        return Ok();
    }
}