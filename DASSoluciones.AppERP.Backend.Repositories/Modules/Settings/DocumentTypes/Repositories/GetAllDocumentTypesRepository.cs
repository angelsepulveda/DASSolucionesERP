namespace DASSoluciones.AppERP.Backend.Repositories.Modules.Settings.DocumentTypes.Repositories;

public class GetAllDocumentTypesRepository(IGetAllDocumentTypesDataSource dataSource) : IGetAllDocumentTypesRepository
{
    public Task<IEnumerable<DocumentType>> HandleAsync() =>
        dataSource.HandleAsync(documentTypesModels =>
            documentTypesModels.OrderBy(x => x.Name)
                .Select(x =>
                    DocumentType.FromPrimtives(x.Id, x.Name, x.Code, x.Description, x.Status)));
}