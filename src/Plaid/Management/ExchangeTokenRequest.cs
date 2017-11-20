using Newtonsoft.Json;

namespace Acklann.Plaid.Management
{
    public class ExchangeTokenRequest : SerializableContent
    {
        [JsonProperty("public_token")]
        public string PublicToken { get; set; }

        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }
    }
}