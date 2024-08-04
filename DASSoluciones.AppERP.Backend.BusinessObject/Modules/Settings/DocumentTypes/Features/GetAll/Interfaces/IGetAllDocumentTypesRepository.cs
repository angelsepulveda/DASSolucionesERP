namespace DASSoluciones.AppERP.Backend.BusinessObject.Modules.Settings.DocumentTypes.Features.GetAll.Interfaces;

public interface IGetAllDocumentTypesRepository
{
    Task<IEnumerable<DocumentType>> HandleAsync();
}