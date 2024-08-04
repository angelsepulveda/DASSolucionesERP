namespace DASSoluciones.AppERP.Backend.Controllers;

public static class EndpointsContainer
{
    public static WebApplication UseControllersEndpoints(this WebApplication app)
    {
        app.UseSettingsEndpoints();

        return app;
    }
}