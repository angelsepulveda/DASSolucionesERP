namespace DASSoluciones.AppERP.Frontend.WebApiProxies;

public static class DependencyContainer
{
    public static IServiceCollection AddModels(this IServiceCollection services, Action<HttpClient> configureHttpClient,
        Action<IHttpClientBuilder> httpClientBuilder)

    {
        services.AddSettingModels(configureHttpClient,httpClientBuilder);

        return services;
    }
}