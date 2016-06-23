using Newtonsoft.Json;

namespace Gigobyte.Plaid.Contract

{
    [JsonObject]
    public class SendOption
    {
        [JsonProperty("mask")]
        public string Mask { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}