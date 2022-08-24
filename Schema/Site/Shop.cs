using jd.poc.Schema.Component;
using Newtonsoft.Json;
using Squidex.ClientLibrary;

namespace jd.poc.Schema.Site
{
    public sealed class Shop : Content<ShopData> { }
    public class ShopData
    {
        [JsonConverter(typeof(InvariantConverter))]
        public List<Banner> Banners{ get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        public List<Guid> Showcase { get; set; } = new List<Guid>();

        [JsonConverter(typeof(InvariantConverter))]
        public Seo Seo { get; set; }
    }
}
