namespace DASSoluciones.AppERP.Frontend.ViewModels.Modules.Settings.DocumentTypes;

public static class DependencyContainer
{
    public static IServiceCollection AddDocumentTypesViewModels(this IServiceCollection services)
    {
        services.AddScoped<GetDocumentTypesViewModel>();
        
        return services;
    }
}