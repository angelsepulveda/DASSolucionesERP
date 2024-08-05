namespace DASSoluciones.AppERP.Frontend.ViewModels.Modules.Settings.DocumentTypes;

public class GetAllDocumentTypesViewModel(IGetAllDocumentTypesModel model)
{
    public IEnumerable<GetAllDocumentTypesDto> DocumentTypes { get; private set; } = null!;

    public async Task HandleAsync()
    {
        DocumentTypes = await model.HandleAsync();
    }
}