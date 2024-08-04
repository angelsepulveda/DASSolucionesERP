namespace DASSoluciones.AppERP.Backend.Repositories.Modules.Settings;

public static class DependencyContainer
{
    public static IServiceCollection AddSettingsRepositories(this IServiceCollection services)
    {
        services.AddDocumentTypesRepositories();

        return services;
    }
}