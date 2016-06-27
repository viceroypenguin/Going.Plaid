using Newtonsoft.Json;

namespace Gigobyte.Plaid.Contract

{
    [JsonObject]
    public class DeliveryOption
    {
        [JsonProperty("mask")]
        public string Mask { get; set; }
        
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}