namespace DASSoluciones.AppERP.EFCore.DataSources.Modules.Settings;

public static class DependencyContainer
{
    public static IServiceCollection AddSettingsDataSources(this IServiceCollection services)
    {
        services.AddDocumentTypesDataSource();
        
        return services;
    }
}