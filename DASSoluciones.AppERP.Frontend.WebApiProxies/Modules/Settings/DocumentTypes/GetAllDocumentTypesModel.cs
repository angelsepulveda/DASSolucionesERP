namespace DASSoluciones.AppERP.Frontend.WebApiProxies.Modules.Settings.DocumentTypes;

public class GetAllDocumentTypesModel(HttpClient httpClient) : IGetAllDocumentTypesModel
{
    public async Task<IEnumerable<GetAllDocumentTypesDto>> HandleAsync()
    {
        var documentTypes =
            await httpClient.GetFromJsonAsync<IEnumerable<GetAllDocumentTypesDto>>(EndpointsDocumentType.GetAll);

        return documentTypes ?? [];
    }
}