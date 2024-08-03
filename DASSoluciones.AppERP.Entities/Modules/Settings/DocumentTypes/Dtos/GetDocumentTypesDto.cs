namespace DASSoluciones.AppERP.Entities.Modules.Settings.DocumentTypes.Dtos;

public class GetDocumentTypesDto(Guid id, string name)
{
    public Guid Id => id;
    public string Name => name;
}