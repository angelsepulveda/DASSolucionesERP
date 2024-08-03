namespace DASSoluciones.AppERP.Frontend.WebApiProxies.Modules.Settings;

public static class DependencyContainer
{
    public static IServiceCollection AddSettingModels(this IServiceCollection services)
    {
        services.AddDocumentTypesModels();
        
        return services;
    }
}