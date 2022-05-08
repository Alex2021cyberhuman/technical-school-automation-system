namespace Application;

public static class ResourceExtensions
{
    public static void UseResourceRequestLocalization(this WebApplication app)
    {
        var supportedCultures = new[] { "ru-RU" };
        var localizationOptions = new RequestLocalizationOptions().SetDefaultCulture(supportedCultures[0])
            .AddSupportedCultures(supportedCultures)
            .AddSupportedUICultures(supportedCultures);

        app.UseRequestLocalization(localizationOptions);
    }
}