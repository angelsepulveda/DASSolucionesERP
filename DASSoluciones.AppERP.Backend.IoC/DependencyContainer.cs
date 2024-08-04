namespace DASSoluciones.AppERP.Backend.IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddAppERPServices(this IServiceCollection services,
        Action<DBOptions> configureDBOptions)
    {
        services.AddUseCasesServices()
            .AddRepositories()
            .AddDataSources(configureDBOptions)
            .AddPresenters();
        return services;
    }
}