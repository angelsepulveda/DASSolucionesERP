namespace DASSoluciones.AppERP.Frontend.WebApiProxies.Modules.Settings;

public static class DependencyContainer
{
    public static IServiceCollection AddSettingModels(this IServiceCollection services,
        Action<HttpClient> configureHttpClient, Action<IHttpClientBuilder> httpClientBuilder)

    {
        services.AddDocumentTypesModels(configureHttpClient,httpClientBuilder);

        return services;
    }
}