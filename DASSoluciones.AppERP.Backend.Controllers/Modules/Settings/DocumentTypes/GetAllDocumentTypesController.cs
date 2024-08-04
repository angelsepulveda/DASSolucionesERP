namespace DASSoluciones.AppERP.Backend.Controllers.Modules.Settings.DocumentTypes;

public static class GetAllDocumentTypesController
{
    public static WebApplication UseGetAllDocumentTypesController(this WebApplication app)
    {
        app.MapGet(EndpointsDocumentType.GetAll,
            async (IGetAllDocumentTypesInputPort inputPort, IGetAllDocumentTypesOutputPort presenter) =>
            {
                await inputPort.HandleAsync();
                var result = presenter.DocumentTypes;
                return TypedResults.Ok(result);
            });

        return app;
    }
}