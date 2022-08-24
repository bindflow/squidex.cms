using Newtonsoft.Json;
using Squidex.ClientLibrary;

namespace jd.poc.Schema.Site
{
    public sealed class Theme : Content<ThemeData> { }

    public class ThemeData
    {
        [JsonConverter(typeof(InvariantConverter))]
        public string TextPrimary { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        public string Primary { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        public string AppbarBackground { get; set; }
    }
}
