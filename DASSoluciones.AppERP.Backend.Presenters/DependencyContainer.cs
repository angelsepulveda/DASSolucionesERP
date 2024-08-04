namespace DASSoluciones.AppERP.Backend.Presenters;

public static class DependencyContainer
{
    public static IServiceCollection AddPresenters(this IServiceCollection services)
    {
        services.AddSettingsPresenters();
        
        return services;
    }
}