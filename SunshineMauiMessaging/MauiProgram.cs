namespace SunshineMauiMessaging;

using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;

using Microsoft.Extensions.Logging;

using SunshineMauiMessaging.Extensions;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        MauiAppBuilder builder = MauiApp.CreateBuilder();

        builder
        // Initialize the .NET MAUI Community Toolkit by adding the below line of code
        .UseMauiCommunityToolkit()
        .UseMauiCommunityToolkitMarkup()
        .UseMauiCommunityToolkitMediaElement()
        // End Community Toolkit
        .UseMauiApp<App>()
        .ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
        })
        .Services.AddAppServices();
#if DEBUG
        builder.Logging.AddDebug();
#endif
        return builder.Build();
    }
}