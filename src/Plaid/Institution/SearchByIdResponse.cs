using Newtonsoft.Json;

namespace Acklann.Plaid.Institution
{
    public class SearchByIdResponse : ResponseBase
    {
        [JsonProperty("institution")]
        public Entity.Institution Institution { get; set; }
    }
}