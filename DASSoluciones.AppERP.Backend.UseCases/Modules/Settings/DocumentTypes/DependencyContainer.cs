namespace DASSoluciones.AppERP.Backend.UseCases.Modules.Settings.DocumentTypes;

public static class DependencyContainer
{
    public static IServiceCollection AddDocumentTypesUseCasesServices(this IServiceCollection services)
    {
        services.AddScoped<IGetAllDocumentTypesInputPort, GetAllDocumentTypesInteractor>();
        
        return services;
        
    }
    
}