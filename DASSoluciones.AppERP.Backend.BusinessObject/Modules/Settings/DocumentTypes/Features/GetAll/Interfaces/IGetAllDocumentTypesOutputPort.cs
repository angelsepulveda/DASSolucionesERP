namespace DASSoluciones.AppERP.Backend.BusinessObject.Modules.Settings.DocumentTypes.Features.GetAll.Interfaces;

public interface IGetAllDocumentTypesOutputPort
{
    IEnumerable<GetAllDocumentTypesDto> DocumentTypes { get; }
    Task HandleResultAsync(IEnumerable<DocumentType> documentTypes);
}