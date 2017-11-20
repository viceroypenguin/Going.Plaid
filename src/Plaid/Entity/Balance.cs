using Newtonsoft.Json;

namespace Acklann.Plaid.Entity
{
    public struct Balance
    {
        [JsonProperty("current")]
        public float Current { get; set; }

        [JsonProperty("available")]
        public float? Available { get; set; }

        [JsonProperty("limit")]
        public float? Limit { get; set; }
    }
}