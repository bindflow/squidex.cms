using Squidex.ClientLibrary;

namespace jd.poc.Service.Squidex
{
    public class SquidexService<TEntity, TData> : ISquidexService<TEntity, TData>
        where TEntity : Content<TData>
        where TData : class, new()
    {
        private readonly SquidexClientManager _manager;

        public SquidexService(IConfiguration configuration)
        {
            var options = new SquidexOptions
            {
                Url = configuration["ClientUrl"],
                AppName = configuration["AppName"],
                ClientId = configuration["ClientId"],
                ClientSecret = configuration["ClientSecret"]
            };

            _manager = new SquidexClientManager(options);
        }

        public IContentsClient<TEntity, TData> Client(string schemaName)
        {
            try
            {
                return _manager.CreateContentsClient<TEntity, TData>(schemaName);
            }
            catch (SquidexException e)
            {
                throw new Exception(e.NormalizeResponse());
            }
        }

        public IContentsClient<DynamicContent, DynamicData> DynamicClient(string schemaName)
        {
            try
            {
                return _manager.CreateDynamicContentsClient(schemaName);
            }
            catch (SquidexException e)
            {
                throw new Exception(e.NormalizeResponse());
            }
        }

        public string? GenerateImageUri(Guid? id)
        {
            try
            {
                return _manager.GenerateImageUrl(id?.ToString());
            }
            catch (SquidexException e)
            {
                throw new Exception(e.NormalizeResponse());
            }
        }
    }
}