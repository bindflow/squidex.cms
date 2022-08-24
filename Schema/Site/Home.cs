using jd.poc.Schema.Component;
using Newtonsoft.Json;
using Squidex.ClientLibrary;

namespace jd.poc.Schema.Site
{
    public sealed class Home : Content<HomeData> { }

    public class HomeData
    {
        [JsonConverter(typeof(InvariantConverter))]
        public string Title { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        public string Description { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        public List<Guid> Image { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        public Seo Seo { get; set; }
    }
}