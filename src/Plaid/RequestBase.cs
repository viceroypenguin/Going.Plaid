using Newtonsoft.Json;

namespace Acklann.Plaid
{
    public abstract class RequestBase
    {
        public RequestBase()
        {
            SerializerSettings = new JsonSerializerSettings()
            {
                DateFormatString = "yyyy-MM-dd",
                NullValueHandling = NullValueHandling.Ignore,
#if DEBUG
                Formatting = Formatting.Indented
#else
                Formatting = Formatting.None
#endif
            };
        }

        protected JsonSerializerSettings SerializerSettings;

        [JsonProperty("secret")]
        public string Secret { get; set; }

        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, SerializerSettings);
        }
    }
}