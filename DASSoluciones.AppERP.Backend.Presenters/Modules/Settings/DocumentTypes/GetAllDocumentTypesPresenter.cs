namespace DASSoluciones.AppERP.Backend.Presenters.Modules.Settings.DocumentTypes;

internal sealed class GetAllDocumentTypesPresenter : IGetAllDocumentTypesOutputPort
{
    public IEnumerable<GetAllDocumentTypesDto> DocumentTypes { get; private set; }
    public Task HandleResultAsync(IEnumerable<DocumentType> documentTypes)
    {
        DocumentTypes = documentTypes.Select(x =>
            new GetAllDocumentTypesDto(x.Id.Value, x.Name, x.Code, x.Description, x.Status));

        return Task.CompletedTask;
    }
}