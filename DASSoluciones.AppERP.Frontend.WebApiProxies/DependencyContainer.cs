namespace DASSoluciones.AppERP.Frontend.WebApiProxies;

public static class DependencyContainer
{
    public static IServiceCollection AddModels(this IServiceCollection services)
    {
        services.AddSettingModels();
        
        return services;
    }
}