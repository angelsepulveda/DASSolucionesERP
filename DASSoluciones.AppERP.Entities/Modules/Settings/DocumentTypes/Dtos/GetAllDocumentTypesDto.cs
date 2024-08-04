namespace DASSoluciones.AppERP.Entities.Modules.Settings.DocumentTypes.Dtos;

public class GetAllDocumentTypesDto(Guid id,string name, string? code, string? description, bool status)
{
    public Guid Id => id;
    public string Name => name;
    public string? Code => code;
    public string? Description => description;
    public bool Status => status;
}