namespace DASSoluciones.AppERP.Backend.BusinessObject.Modules.Settings.DocumentTypes.Entities;

public class DocumentType
{
    public DocumentTypeId Id { get; private set; }
    public string Name { get; private set; }
    public string? Code { get; private set; }
    public string? Description { get; private set; }
    public bool Status { get; private set; }

    private DocumentType(DocumentTypeId id, string name, string? code, string? description, bool status)
    {
        Id = id;
        Name = name;
        Code = code;
        Description = description;
        Status = status;
    }

    public static DocumentType Create(string name, string? code, string? description)
    {
        var documentTypeId = new DocumentTypeId(Guid.NewGuid());
        var documentTypeStatus = true;

        return new DocumentType(documentTypeId, name, code, description, documentTypeStatus);
    }

    public void Delete()
    {
        Status = false;
    }

    public void Restore()
    {
        Status = true;
    }

    public static DocumentType FromPrimtives(Guid id, string name, string? code, string? description, bool status)
    {
        var documentTypeId = new DocumentTypeId(id);

        return new DocumentType(documentTypeId, name, code, description, status);
    }
}