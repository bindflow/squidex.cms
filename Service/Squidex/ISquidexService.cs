using Squidex.ClientLibrary;

namespace jd.poc.Service.Squidex
{
    public interface ISquidexService<TEntity, TData> where TEntity : Content<TData>
           where TData : class, new()
    {
        string? GenerateImageUri(Guid? id);
        IContentsClient<TEntity, TData> Client(string schemaName);
        IContentsClient<DynamicContent, DynamicData> DynamicClient(string schemaName);
    }
}
