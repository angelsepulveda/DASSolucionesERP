namespace DASSoluciones.AppERP.Backend.Controllers.Modules.Settings;

public static class EndpointsContainer
{
    public static WebApplication UseSettingsEndpoints(this WebApplication app)
    {
        app.UseDocumentTypesEndpoints();
        
        return app;
    }
}