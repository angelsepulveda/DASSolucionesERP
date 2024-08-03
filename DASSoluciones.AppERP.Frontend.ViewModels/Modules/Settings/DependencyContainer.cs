namespace DASSoluciones.AppERP.Frontend.ViewModels.Modules.Settings;

public static class DependencyContainer
{
    public static IServiceCollection AddSettingsViewModels(this IServiceCollection services)
    {
        services.AddDocumentTypesViewModels();
        
        return services;
    }
}