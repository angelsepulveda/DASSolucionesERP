namespace DASSoluciones.AppERP.Frontend.IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddAppERPServices(this IServiceCollection services,
        Action<AppERPOptions> configureAppERPOptions)
    {
        AppERPOptions options = new();
        configureAppERPOptions(options);

        services.AddModels(
            httpClient => httpClient.BaseAddress = new Uri(options.WebApiBaseAddress), null);
        services.AddViewModels();

        services.AddSingleton(Options.Create(options));

        return services;
    }
}