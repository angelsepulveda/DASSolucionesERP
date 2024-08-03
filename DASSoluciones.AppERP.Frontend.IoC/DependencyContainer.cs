namespace DASSoluciones.AppERP.Frontend.IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddAppERPServices(this IServiceCollection services)
    {
        services.AddModels();
        services.AddViewModels();
        
        return services;
    }
}