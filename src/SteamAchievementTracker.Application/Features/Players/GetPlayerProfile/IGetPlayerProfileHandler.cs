namespace SteamAchievementTracker.Application.Features.Players.GetPlayerProfile;

public interface IGetPlayerProfileHandler
{
    Task<PlayerProfileDto> HandleAsync(string steamId, CancellationToken cancellationToken = default);
}
