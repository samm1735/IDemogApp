using CommunityToolkit.Maui;
using IDemogApp.Services;
using IDemogApp.ViewModels;
using IDemogApp.Views;
using Microsoft.Extensions.Logging;

namespace IDemogApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<PersonneService>();

            builder.Services.AddSingleton<AjoutPage>();
            builder.Services.AddSingleton<AjoutPageViewModel>();

            builder.Services.AddSingleton<PersonneDatabase>();

            return builder.Build();
        }
    }
}
