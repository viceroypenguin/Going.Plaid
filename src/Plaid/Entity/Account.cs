using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Acklann.Plaid.Entity
{
    public class Account
    {
        [JsonProperty(JName.Id)]
        public string Id { get; set; }

        [JsonProperty(JName.Item)]
        public string ItemId { get; set; }

        [JsonProperty(JName.User)]
        public string User { get; set; }

        [JsonProperty(JName.InstitutionType)]
        public string InstitutionType { get; set; }

        [JsonProperty(JName.Type)]
        public string Type { get; set; }

        [JsonProperty(JName.Subtype)]
        public string Subtype { get; set; }

        [JsonProperty(JName.Balance)]
        public Balance Balance { get; set; }

        [JsonProperty(JName.Meta)]
        public JObject Meta { get; set; }
    }
}