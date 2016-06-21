using Newtonsoft.Json;

namespace Gigobyte.Plaid
{
    public abstract class PlaidClientBase
    {
        public PlaidClientBase(string clientId, string secret)
        {
            Secret = secret;
            ClientId = clientId;
        }

        [JsonProperty("secret")]
        protected string Secret { get; set; }

        [JsonProperty("client_id")]
        protected string ClientId { get; set; }

        protected string AccessToken { get; set; }


    }
}