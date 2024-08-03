namespace DASSoluciones.AppERP.Frontend.BusinessObject.Modules.Settings.DocumentTypes.GetDocumentTypes.Interfaces;

public interface IGetDocumentTypesModel
{
    Task<IEnumerable<GetDocumentTypesDto>> HandleAsync();
}