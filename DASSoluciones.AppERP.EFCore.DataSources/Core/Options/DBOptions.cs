namespace DASSoluciones.AppERP.EFCore.DataSources.Core.Options;

public class DBOptions
{
    public const string SectionKey = nameof(DBOptions);
    public string ConnectionStrings { get; set; } = null!;
}