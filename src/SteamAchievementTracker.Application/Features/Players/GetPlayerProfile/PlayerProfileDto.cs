namespace SteamAchievementTracker.Application.Features.Players.GetPlayerProfile;

public sealed record PlayerProfileDto(
    string SteamId,
    string PersonaName,
    string? AvatarUrl,
    bool IsStub);
