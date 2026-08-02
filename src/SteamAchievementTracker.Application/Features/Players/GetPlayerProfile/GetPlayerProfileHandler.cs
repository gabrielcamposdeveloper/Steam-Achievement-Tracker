using SteamAchievementTracker.Domain.Entities;

namespace SteamAchievementTracker.Application.Features.Players.GetPlayerProfile;

/// <summary>
/// Skeleton handler. Returns a stub profile until the Steam API adapter exists.
/// </summary>
public sealed class GetPlayerProfileHandler : IGetPlayerProfileHandler
{
    public Task<PlayerProfileDto> HandleAsync(string steamId, CancellationToken cancellationToken = default)
    {
        // Validates SteamId via the domain entity.
        var player = new Player(
            steamId,
            personaName: $"Player {steamId.Trim()}",
            avatarUrl: null);

        var dto = new PlayerProfileDto(
            player.SteamId,
            player.PersonaName,
            player.AvatarUrl,
            IsStub: true);

        return Task.FromResult(dto);
    }
}
