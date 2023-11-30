using System;
using System.Threading.Tasks;
using Messager.Infastracture.User.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Messager.Controllers;

[ApiController]
[Route("api/v1/friends")]
public class FriendsController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetFriendsAsync([FromQuery] Guid id)
    {
        return Ok();
    }

    [HttpPost("add")]
    public async Task<IActionResult> AddFriendAsync([FromBody] AddFriendRequest request)
    {
        return Ok();
    }

    [HttpPost("accept")]
    public async Task<IActionResult> AcceptFriendRequestAsync()
    {
        return Ok();
    }
}