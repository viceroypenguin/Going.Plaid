using Newtonsoft.Json;

namespace Acklann.Plaid.Entity
{
    public class Institution
    {
        [JsonProperty("institution_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("has_mfa")]
        public bool HasMfa { get; set; }

        [JsonProperty("mfa")]
        public string[] MfaSelections { get; set; }

        [JsonProperty("credentials")]
        public Credential[] Credentials { get; set; }

        [JsonProperty("products")]
        public string[] Products { get; set; }

        public struct Credential
        {
            [JsonProperty("label")]
            public string Label { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("type")]
            public string DataType { get; set; }
        }
    }
}