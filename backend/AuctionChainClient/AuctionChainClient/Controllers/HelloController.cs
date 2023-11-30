using Microsoft.AspNetCore.Mvc;

namespace AuctionChainClient.Controllers;

[ApiController]
[Route("hello")]
public class HelloController : ControllerBase
{
    [HttpGet("auctions")]
    public async Task<IActionResult> GetAuctions()
    {
        var client = new HttpClient();
        var result = await client.GetAsync("http://localhost:5121/api/v1/auctions");
        return Ok();
    }
}