namespace SteamAchievementTracker.Domain.Entities;

public sealed class Player
{
    public string SteamId { get; }
    public string PersonaName { get; }
    public string? AvatarUrl { get; }

    public Player(string steamId, string personaName, string? avatarUrl = null)
    {
        if (string.IsNullOrWhiteSpace(steamId))
        {
            throw new ArgumentException("SteamId is required.", nameof(steamId));
        }

        if (string.IsNullOrWhiteSpace(personaName))
        {
            throw new ArgumentException("PersonaName is required.", nameof(personaName));
        }

        SteamId = steamId.Trim();
        PersonaName = personaName.Trim();
        AvatarUrl = string.IsNullOrWhiteSpace(avatarUrl) ? null : avatarUrl.Trim();
    }
}
