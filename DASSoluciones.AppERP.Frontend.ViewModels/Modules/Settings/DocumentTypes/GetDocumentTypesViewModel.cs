namespace DASSoluciones.AppERP.Frontend.ViewModels.Modules.Settings.DocumentTypes;

public class GetDocumentTypesViewModel(IGetDocumentTypesModel model)
{
    public IEnumerable<GetDocumentTypesDto> DocumentTypes { get; private set; }

    public async Task HandleAsync()
    {
        DocumentTypes = await model.HandleAsync();
    }
}