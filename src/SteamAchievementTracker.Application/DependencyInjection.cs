using Microsoft.Extensions.DependencyInjection;
using SteamAchievementTracker.Application.Features.Players.GetPlayerProfile;

namespace SteamAchievementTracker.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IGetPlayerProfileHandler, GetPlayerProfileHandler>();
        return services;
    }
}
