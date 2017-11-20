using Newtonsoft.Json;

namespace Acklann.Plaid.Institution
{
    public class SearchRequest : SerializableContent
    {
        public SearchRequest()
        {
            NullValueHandling = NullValueHandling.Include;
        }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("products")]
        public string[] Products { get; set; }

        [JsonProperty("public_key")]
        public string PublicKey { get; set; }
    }
}