namespace DASSoluciones.AppErp.Frontend.RazorViews.Modules.Settings.DocumentTypes.Components;

public partial class DocumentType : ComponentBase
{
    [Inject]
    public GetDocumentTypesViewModel ViewModel { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await ViewModel.HandleAsync();
    }
}