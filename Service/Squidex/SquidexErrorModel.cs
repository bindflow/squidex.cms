using Squidex.ClientLibrary;
using System.Text.Json.Serialization;

namespace jd.poc.Service.Squidex
{
    public class SquidexErrorModel
    {
        [JsonConverter(typeof(InvariantConverter))]
        public string Message { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        public string TraceId { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        public string Type { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        public List<string> Details { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        public int StatusCode { get; set; }
    }
}