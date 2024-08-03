namespace DASSoluciones.AppERP.Frontend.ViewModels;

public static class DependencyContainer
{
    public static IServiceCollection AddViewModels(this IServiceCollection services)
    {
        services.AddSettingsViewModels();
        
        return services;
    }
}