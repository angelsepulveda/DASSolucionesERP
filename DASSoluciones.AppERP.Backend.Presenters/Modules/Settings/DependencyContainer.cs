namespace DASSoluciones.AppERP.Backend.Presenters.Modules.Settings;

public static class DependencyContainer
{
    public static IServiceCollection AddSettingsPresenters(this IServiceCollection services)
    {
        services.AddDocumentTypesPresenters();

        return services;
    }
}