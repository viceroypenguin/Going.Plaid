using Newtonsoft.Json;

namespace Acklann.Plaid.Institution
{
    public class SearchByIdRequest : SerializableContent
    {
        [JsonProperty("institution_id")]
        public string InstitutionId { get; set; }

        [JsonProperty("public_key")]
        public string PublicKey { get; set; }
    }
}