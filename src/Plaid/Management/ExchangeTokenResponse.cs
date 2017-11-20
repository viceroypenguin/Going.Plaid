using Newtonsoft.Json;

namespace Acklann.Plaid.Management
{
    public class ExchangeTokenResponse : ResponseBase
    {
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
    }
}