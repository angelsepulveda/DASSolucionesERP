namespace DASSoluciones.AppERP.Frontend.WebApiProxies.Modules.Settings.DocumentTypes;

public static class DependencyContainer
{
    public static IServiceCollection AddDocumentTypesModels(this IServiceCollection services,
        Action<HttpClient> configureHttpClient, Action<IHttpClientBuilder> httpClientBuilder)
    {
        services.AddScoped<IGetDocumentTypesModel, GetDocumentTypesModel>();
        
        IHttpClientBuilder builder =
            services.AddHttpClient<IGetAllDocumentTypesModel, GetAllDocumentTypesModel>(configureHttpClient);
        
        httpClientBuilder?.Invoke(builder);

        return services;
    }
}