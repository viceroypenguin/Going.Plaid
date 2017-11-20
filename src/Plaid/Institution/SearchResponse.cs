using Acklann.Plaid.Entity;
using Newtonsoft.Json;

namespace Acklann.Plaid.Institution
{
    public class SearchResponse : ResponseBase
    {
        [JsonProperty("institutions")]
        public Entity.Institution[] Institutions { get; set; }
    }
}