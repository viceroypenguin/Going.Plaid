using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace Acklann.Plaid.Entity
{
    public class Transaction
    {
        [JsonProperty(JName.Id)]
        public string Id { get; set; }

        [JsonProperty(JName.Account)]
        public string AccountId { get; set; }

        [JsonProperty(JName.Amount)]
        public float Amount { get; set; }

        [JsonProperty(JName.Date)]
        public DateTime Date { get; set; }

        [JsonProperty(JName.Name)]
        public string Name { get; set; }

        [JsonProperty(JName.Meta)]
        public JObject Metadata { get; set; }

        [JsonProperty(JName.Pending)]
        public bool Pending { get; set; }

        [JsonProperty(JName.Category)]
        public string[] Categories { get; set; }

        [JsonProperty(JName.CategoryId)]
        public int CategoryId { get; set; }

        [JsonProperty(JName.Score)]
        public Score Score { get; set; }
    }
}