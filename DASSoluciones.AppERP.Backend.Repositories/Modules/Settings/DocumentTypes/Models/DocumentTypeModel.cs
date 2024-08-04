namespace DASSoluciones.AppERP.Backend.Repositories.Modules.Settings.DocumentTypes.Models;

public class DocumentTypeModel : BaseModel<Guid>
{
    public string Name { get; set; }
    public string? Code { get; set; }
    public string? Description { get; set; }
    public bool Status { get; set; }
}