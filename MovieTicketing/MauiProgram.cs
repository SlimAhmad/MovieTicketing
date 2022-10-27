using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace MovieTicketing
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>()
                   .UseMauiMaps()
                   .UseMauiCommunityToolkit()
                   .UseMauiCommunityToolkitMarkup()
                   .ConfigureFonts(fonts =>
                   {
                       fonts.AddFont("Nunito-Regular.ttf", "NunitoRegular");
                       fonts.AddFont("Nunito-SemiBold.ttf", "NunitoSemiBold");
                       fonts.AddFont("Nunito-Regular.ttf", "NunitoExtraBold");
                       fonts.AddFont("Nunito-Bold.ttf", "NunitoBold");
                       fonts.AddFont("Nunito-Black.ttf", "NunitoBlack");
                       fonts.AddFont("Nunito-Light.ttf", "NunitoLight");
                   });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
