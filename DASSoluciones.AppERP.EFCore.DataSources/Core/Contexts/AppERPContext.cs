namespace DASSoluciones.AppERP.EFCore.DataSources.Core.Contexts;

public class AppERPContext(IOptions<DBOptions> options) : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(options.Value.ConnectionStrings);
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DocumentTypeModelConfiguration).Assembly);
        base.OnModelCreating(modelBuilder);
    }
    
    public DbSet<DocumentTypeModel> DocumentTypes { get; set; }
}