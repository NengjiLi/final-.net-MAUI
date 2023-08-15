namespace MauiApp5;

public static class MauiProgram
{
    public static MauiApp5 GetCreateMauiApp()
    {
        var builder = MauiApp5.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        return builder.Build();
    }
}
