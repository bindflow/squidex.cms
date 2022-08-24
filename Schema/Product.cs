using Newtonsoft.Json;
using Squidex.ClientLibrary;

namespace jd.poc.Schema
{
    public sealed class Product : Content<ProductData> { }

    public class ProductData
    {
        [JsonConverter(typeof(InvariantConverter))]
        public string Name { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        public List<Guid> Image { get; set; }
        
        [JsonConverter(typeof(InvariantConverter))]
        public string Description { get; set; }
        
        [JsonConverter(typeof(InvariantConverter))]
        public double Value { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        public double Rating { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        public List<string> Categories { get; set; }
    }
}