using jd.poc.Schema.Component;
using NC.Blazor.Vuezor;
using Newtonsoft.Json;
using Squidex.ClientLibrary;

namespace jd.poc.Schema.Site
{
    public sealed class Build : Content<BuildData> { }

    public class BuildData
    {
        [JsonConverter(typeof(InvariantConverter))]
        public List<Bag> Components { get; set; }

        [JsonConverter(typeof(InvariantConverter))]
        public Seo Seo { get; set; }
    }

    public class BuildVM : VueVM
    {
        protected override bool IsOnewaySyncSupported => false;

        public int counter { get; set; }

        public void Increment()
        {
            this.counter++;
        }
    }
}
