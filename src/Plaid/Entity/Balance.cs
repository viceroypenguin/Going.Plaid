using Newtonsoft.Json;

namespace Acklann.Plaid.Entity
{
    public struct Balance
    {
        [JsonProperty("current")]
        public decimal Current { get; set; }

        [JsonProperty("available")]
        public decimal Available { get; set; }
    }
}