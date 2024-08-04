namespace DASSoluciones.AppERP.Backend.Controllers.Modules.Settings.DocumentTypes;

public static class EndpointsContainer
{
    public static WebApplication UseDocumentTypesEndpoints(this WebApplication app)
    {
        app.UseGetAllDocumentTypesController();
        
        return app;
    }
}