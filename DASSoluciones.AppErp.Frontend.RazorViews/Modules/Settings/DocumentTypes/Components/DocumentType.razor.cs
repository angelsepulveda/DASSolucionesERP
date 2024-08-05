using Radzen;

namespace DASSoluciones.AppErp.Frontend.RazorViews.Modules.Settings.DocumentTypes.Components;

public partial class DocumentType : ComponentBase
{
    [Inject]
    public GetAllDocumentTypesViewModel ViewModel { get; set; }
   

    public PagerPosition pagerPosition = PagerPosition.Bottom;

    protected override async Task OnInitializedAsync()
    {
        await ViewModel.HandleAsync();
    }
}