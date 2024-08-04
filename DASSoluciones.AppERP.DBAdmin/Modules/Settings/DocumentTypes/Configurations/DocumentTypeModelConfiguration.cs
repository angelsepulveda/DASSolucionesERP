namespace DASSoluciones.AppERP.DBAdmin.Modules.Settings.DocumentTypes.Configurations;

public class DocumentTypeModelConfiguration : IEntityTypeConfiguration<DocumentTypeModel>
{
    public void Configure(EntityTypeBuilder<DocumentTypeModel> builder)
    {
        builder.ToTable("DocumentType");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnType("char(36)");
        builder.Property(x => x.Name).HasColumnType("varchar(20)").HasMaxLength(20).IsRequired();
        builder.Property(x => x.Code).HasColumnType("varchar(10)").HasMaxLength(10);
        builder.Property(x => x.Description).HasColumnType("varchar(255)").HasMaxLength(255);
        builder.Property(x => x.Status).IsRequired();
        builder.Property(x => x.CreatedBy).HasColumnType("varchar(255)").HasMaxLength(255);
        builder.Property(x => x.UpdatedBy).HasColumnType("varchar(255)").HasMaxLength(255);

        builder.HasData(new DocumentTypeModel
            { Id = Guid.NewGuid(), Name = "RUN", Code = "001", Description = "Ejemplo descripcion", Status = true });
    }
}