namespace DASSoluciones.AppERP.Frontend.WebApiProxies.Modules.Settings.DocumentTypes;

internal class GetDocumentTypesModel : IGetDocumentTypesModel
{
    private IEnumerable<GetDocumentTypesDto> DocumentTypes =
    [
        new GetDocumentTypesDto(Guid.NewGuid(), "Hola mUNDO")
    ];

    public async Task<IEnumerable<GetDocumentTypesDto>> HandleAsync() => await Task.FromResult(DocumentTypes);
}