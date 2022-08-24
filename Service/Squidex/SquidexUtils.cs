using Newtonsoft.Json;
using Squidex.ClientLibrary;

namespace jd.poc.Service.Squidex
{
    public static class SquidexUtils
    {
        public static string NormalizeResponse(this SquidexException e)
        {
            const string fst = "{";
            const string lst = "}";

            var p1 = e.Message.IndexOf(fst) + fst.Length;
            var p2 = e.Message.IndexOf(lst);

            var content = e.Message[p1..p2];

            var options = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
            var validations = JsonConvert.DeserializeObject<SquidexErrorModel>($"{fst}{content}{lst}", options);

            if (validations != null)
                return string.Join(" ", validations.Details);

            return "Client cms conection error";
        }
    }
}
