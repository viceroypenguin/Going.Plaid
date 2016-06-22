using Newtonsoft.Json;

namespace Gigobyte.Plaid.Contract
{
    [JsonObject]
    public class TransactionType
    {
        [JsonProperty("primary")]
        public string Primary { get; set; }
    }
}