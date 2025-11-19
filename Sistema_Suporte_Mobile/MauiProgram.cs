using Microsoft.Extensions.Logging;
using System.IO;
using Microsoft.Maui.Controls;

using Sistema_Suporte_Mobile.Models;
using Sistema_Suporte_Mobile.Services;
using Sistema_Suporte_Mobile.ViewModels;

namespace Sistema_Suporte_Mobile;


public static class MauiProgram
{
    public static object Services { get; internal set; }

    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
        .UseMauiApp<App>()
        .ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
        });


#if DEBUG
        builder.Logging.AddDebug();
#endif


        // Services
        builder.Services.AddSingleton<Services.IApiService, Services.ApiService>();
        builder.Services.AddSingleton<Services.IIaService, Services.IaService>();
        builder.Services.AddSingleton(sp => new OpenAiService("OPENAI_KEY"));


        // Local DB path
        var dbPath = Path.Combine(FileSystem.AppDataDirectory, "suporte.db");
        builder.Services.AddSingleton(new Services.LocalDbService(dbPath));


        // ViewModels
        builder.Services.AddTransient<ViewModels.LoginViewModel>();
        builder.Services.AddTransient<ViewModels.TicketsViewModel>();
        builder.Services.AddTransient<ViewModels.TicketDetailViewModel>();
        builder.Services.AddTransient<ViewModels.NewTicketViewModel>();


        // Pages
        builder.Services.AddTransient<Views.LoginPage>();
        builder.Services.AddTransient<Views.TicketsPage>();
        builder.Services.AddTransient<Views.TicketDetailPage>();
        builder.Services.AddTransient<Views.NewTicketPage>();

        //builder.Services.AddSingleton<IAuthService, AuthService>();

        return builder.Build();
    }
}
