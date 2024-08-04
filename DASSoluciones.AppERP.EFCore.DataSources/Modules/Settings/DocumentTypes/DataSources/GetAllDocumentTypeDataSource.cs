namespace DASSoluciones.AppERP.EFCore.DataSources.Modules.Settings.DocumentTypes.DataSources;

internal sealed class GetAllDocumentTypeDataSource
    : AppERPContext, IGetAllDocumentTypesDataSource
{
    public GetAllDocumentTypeDataSource(IOptions<DBOptions> options) : base(options)
    {
        ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }
    
    public async Task<IEnumerable<DocumentType>> HandleAsync(
        Func<IQueryable<DocumentTypeModel>, IQueryable<DocumentType>> queryBuilder)
    {
        var query = queryBuilder(DocumentTypes);

        return await query.ToListAsync();
    }
}