using SteamAchievementTracker.Domain.Entities;

namespace SteamAchievementTracker.Domain.Tests;

public class PlayerTests
{
    [Fact]
    public void Constructor_WithValidData_CreatesPlayer()
    {
        var player = new Player("76561198000000000", "Gui", "https://example.com/avatar.jpg");

        Assert.Equal("76561198000000000", player.SteamId);
        Assert.Equal("Gui", player.PersonaName);
        Assert.Equal("https://example.com/avatar.jpg", player.AvatarUrl);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("   ")]
    public void Constructor_WithInvalidSteamId_Throws(string? steamId)
    {
        var ex = Assert.Throws<ArgumentException>(() => new Player(steamId!, "Gui"));
        Assert.Equal("steamId", ex.ParamName);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("   ")]
    public void Constructor_WithInvalidPersonaName_Throws(string? personaName)
    {
        var ex = Assert.Throws<ArgumentException>(() => new Player("76561198000000000", personaName!));
        Assert.Equal("personaName", ex.ParamName);
    }

    [Fact]
    public void Constructor_TrimsValues_AndTreatsBlankAvatarAsNull()
    {
        var player = new Player("  76561198000000000  ", "  Gui  ", "   ");

        Assert.Equal("76561198000000000", player.SteamId);
        Assert.Equal("Gui", player.PersonaName);
        Assert.Null(player.AvatarUrl);
    }
}
