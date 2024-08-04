namespace DASSoluciones.AppERP.Backend.IoC;

public static class EndpointsContainer
{
    public static WebApplication UseAppERPEndpoints(this WebApplication app)
    {
        app.UseControllersEndpoints();
        
        return app;
    }
}