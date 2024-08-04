namespace DASSoluciones.AppERP.EFCore.DataSources;

public static class DependencyContainer
{
    public static IServiceCollection AddDataSources(this IServiceCollection services,
        Action<DBOptions> configureDBOptions)
    {
        services.AddSettingsDataSources();

        services.Configure(configureDBOptions);

        return services;
    }
}