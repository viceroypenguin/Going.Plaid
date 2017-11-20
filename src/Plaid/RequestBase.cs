using Newtonsoft.Json;

namespace Acklann.Plaid
{
    public abstract class RequestBase : SerializableContent
    {
        [JsonProperty("secret")]
        public string Secret { get; set; }

        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
    }
}