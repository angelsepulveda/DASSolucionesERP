namespace DASSoluciones.AppERP.Backend.Presenters.Modules.Settings.DocumentTypes;

public static class DependencyContainer
{
    public static IServiceCollection AddDocumentTypesPresenters(this IServiceCollection services)
    {
        services.AddScoped<IGetAllDocumentTypesOutputPort, GetAllDocumentTypesPresenter>();
        
        return services;
    }
}