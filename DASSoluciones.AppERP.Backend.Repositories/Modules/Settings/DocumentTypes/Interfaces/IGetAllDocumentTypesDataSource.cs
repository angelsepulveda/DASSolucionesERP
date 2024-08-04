namespace DASSoluciones.AppERP.Backend.Repositories.Modules.Settings.DocumentTypes.Interfaces;

public interface IGetAllDocumentTypesDataSource
{
    Task<IEnumerable<DocumentType>> HandleAsync(
        Func<IQueryable<DocumentTypeModel>, IQueryable<DocumentType>> queryBuilder);
}