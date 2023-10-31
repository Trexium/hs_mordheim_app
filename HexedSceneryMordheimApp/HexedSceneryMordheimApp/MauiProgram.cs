using Microsoft.Extensions.Logging;
using CommunityToolkit.Mvvm;
using HexedSceneryMordheimApp.ViewModels;
using HexedSceneryMordheimApp.Views;
using HexedSceneryMordheimApp.Services;

namespace HexedSceneryMordheimApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .RegisterServices()
                .RegisterViewModels()
                .RegisterViews();

#if DEBUG
		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<CountExampleViewModel>();
            mauiAppBuilder.Services.AddSingleton<CombatTablesViewModel>();
            mauiAppBuilder.Services.AddSingleton<CriticalHitsViewModel>();
            mauiAppBuilder.Services.AddSingleton<EncountersViewModel>();
            mauiAppBuilder.Services.AddSingleton<PostBattleTablesModelView>();

            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<ITableService, TableService>();

            return mauiAppBuilder;
        }

        public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddTransient<CountExampleView>();
            mauiAppBuilder.Services.AddTransient<CombatTablesView>();
            mauiAppBuilder.Services.AddTransient<CriticalHitsView>();
            mauiAppBuilder.Services.AddTransient<EncountersView>();
            mauiAppBuilder.Services.AddTransient<HomeView>();
            mauiAppBuilder.Services.AddTransient<PostBattleTablesView>();

            return mauiAppBuilder;
        }
    }
}