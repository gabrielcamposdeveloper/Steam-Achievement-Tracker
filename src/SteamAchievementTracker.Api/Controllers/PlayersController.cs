using Microsoft.AspNetCore.Mvc;
using SteamAchievementTracker.Application.Features.Players.GetPlayerProfile;

namespace SteamAchievementTracker.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class PlayersController(IGetPlayerProfileHandler getPlayerProfileHandler) : ControllerBase
{
    [HttpGet("{steamId}")]
    [ProducesResponseType(typeof(PlayerProfileDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<PlayerProfileDto>> GetProfile(
        string steamId,
        CancellationToken cancellationToken)
    {
        try
        {
            var profile = await getPlayerProfileHandler.HandleAsync(steamId, cancellationToken);
            return Ok(profile);
        }
        catch (ArgumentException ex)
        {
            return BadRequest(new { error = ex.Message });
        }
    }
}
