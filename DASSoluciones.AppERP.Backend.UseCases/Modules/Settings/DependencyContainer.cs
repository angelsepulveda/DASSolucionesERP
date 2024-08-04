namespace DASSoluciones.AppERP.Backend.UseCases.Modules.Settings;

public static class DependencyContainer
{
    public static IServiceCollection AddSettingUseCasesServices(this IServiceCollection services)
    {
        services.AddDocumentTypesUseCasesServices();
        
        return services;
    }
}