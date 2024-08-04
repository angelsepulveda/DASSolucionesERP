namespace DASSoluciones.AppERP.Backend.UseCases;

public static class DependencyContainer
{
    public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
    {
        services.AddSettingUseCasesServices();
        
        return services;
    }
}