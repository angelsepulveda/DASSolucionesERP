namespace DASSoluciones.AppERP.EFCore.DataSources.Modules.Settings.DocumentTypes;

public static class DependencyContainer
{
    public static IServiceCollection AddDocumentTypesDataSource(this IServiceCollection services)
    {
        services.AddScoped<IGetAllDocumentTypesDataSource, GetAllDocumentTypeDataSource>();
        
        return services;
    }
}