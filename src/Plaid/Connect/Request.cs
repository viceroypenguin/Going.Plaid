using Acklann.Plaid.Entity;
using Newtonsoft.Json;

namespace Acklann.Plaid.Connect
{
    public class Request : RequestBase
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("pin")]
        public string Pin { get; set; }

        [JsonProperty("options")]
        public SubmitOptions Options { get; set; }
    }
}