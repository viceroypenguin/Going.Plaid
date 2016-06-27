using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace Gigobyte.Plaid.Contract
{
    [JsonObject]
    public class Institution
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("currencyCode")]
        public string Currency { get; set; }

        [JsonProperty("logo")]
        public string LogoByteData { get; set; }

        [JsonProperty("has_mfa")]
        public bool HasMFA { get; set; }

        [JsonProperty("mfa")]
        public string[] Mfa { get; set; }

        [JsonProperty("products")]
        public JToken Products { get; set; }

        public bool CanUse(string mfaType)
        {
            return (Mfa ?? new string[0]).Contains(mfaType);
        }
    }
}