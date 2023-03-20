namespace SunshineMauiMessaging.Extensions;

using CommunityToolkit.Maui;

using SunshineMauiMessaging.Pages;
using SunshineMauiMessaging.ViewModels;

public static class AppExtensions
{
    public static IServiceCollection AddAppServices(this IServiceCollection services)
    {
        _ = services.AddSingleton<App>();
        _ = services.AddSingleton<AppShell>();
        _ = services.AddSingleton<InitialData>();
        _ = services.AddSingleton<CurrentUser>();
        _ = services.AddTransient<IApiInterface, ApiInterface>();
        _ = services.AddSingleton<StartPage, StartPageViewModel>();
        _ = services.AddSingleton<ActivitiesPage, ActivitiesPageViewModel>();

        return services;
    }
}
