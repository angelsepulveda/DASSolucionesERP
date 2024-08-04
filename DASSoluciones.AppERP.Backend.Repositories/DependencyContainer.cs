namespace DASSoluciones.AppERP.Backend.Repositories;

public static class DependencyContainer
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddSettingsRepositories();

        return services;
    }
}