namespace DASSoluciones.AppERP.Frontend.WebApiProxies.Modules.Settings.DocumentTypes;

public static class DependencyContainer
{
    public static IServiceCollection AddDocumentTypesModels(this IServiceCollection services)
    {
        services.AddScoped<IGetDocumentTypesModel, GetDocumentTypesModel>();

        return services;
    }
}