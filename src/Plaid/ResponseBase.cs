using Newtonsoft.Json;

namespace Acklann.Plaid
{
    public abstract class ResponseBase
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
    }
}