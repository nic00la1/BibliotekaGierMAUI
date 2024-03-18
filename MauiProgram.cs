using BibliotekaGierMAUI.MVVM.ViewModels;
using BibliotekaGierMAUI.MVVM.Views;
using BibliotekaGierMAUI.Services;
using BibliotekaGierMAUI.ViewModels;
using Microsoft.Extensions.Logging;

namespace BibliotekaGierMAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .RegisterAppServices()
                .RegisterViewModels()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("NotoSerif-Bold.ttf", "NotoSerifBold");
                    fonts.AddFont("Poppins-Bold.ttf", "PoppinsBold");
                    fonts.AddFont("Poppins-SemiBold.ttf", "PoppinsSemibold");
                    fonts.AddFont("Poppins-Regular.ttf", "Poppins");
                    fonts.AddFont("MaterialIconsOutlined-Regular.otf", "Material");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<IGamesService, MockGamesService>();

            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<HomeViewModel>();
            mauiAppBuilder.Services.AddTransient<GameViewModel>();
            mauiAppBuilder.Services.AddTransient<SectionsViewModel>();
            mauiAppBuilder.Services.AddTransient<CategoryViewModel>();

            mauiAppBuilder.Services.AddTransient<HomePage>();
            mauiAppBuilder.Services.AddTransient<GamePage>();
            mauiAppBuilder.Services.AddTransient<SectionsPage>();
            mauiAppBuilder.Services.AddTransient<CategoryPage>();

            return mauiAppBuilder;
        }
    }
}
