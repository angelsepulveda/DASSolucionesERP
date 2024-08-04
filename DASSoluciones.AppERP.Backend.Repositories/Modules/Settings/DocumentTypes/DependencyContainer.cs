namespace DASSoluciones.AppERP.Backend.Repositories.Modules.Settings.DocumentTypes;

public static class DependencyContainer
{
    public static IServiceCollection AddDocumentTypesRepositories(this IServiceCollection services)
    {
        services.AddScoped<IGetAllDocumentTypesRepository, GetAllDocumentTypesRepository>();

        return services;
    }
}