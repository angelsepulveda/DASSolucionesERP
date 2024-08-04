namespace DASSoluciones.AppERP.Backend.UseCases.Modules.Settings.DocumentTypes.GetAll;

internal class GetAllDocumentTypesInteractor(
    IGetAllDocumentTypesRepository repository,
    IGetAllDocumentTypesOutputPort presenter) : IGetAllDocumentTypesInputPort
{
    public async Task HandleAsync()
    {
        var documentTypes = await repository.HandleAsync();

        await presenter.HandleResultAsync(documentTypes);
    }
}