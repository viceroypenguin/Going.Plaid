using Newtonsoft.Json;

namespace Gigobyte.Plaid.Model
{
    [JsonObject]
    public class AccountMetadata
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("limit")]
        public string Limit { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }
    }
}