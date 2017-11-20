using Newtonsoft.Json;

namespace Acklann.Plaid.Entity
{
    /// <summary>
    /// Represents a transaction's category.
    /// </summary>
    public class Category
    {
        [JsonProperty("category_id")]
        public string Id { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("hierarchy")]
        public string[] Hierarchy { get; set; }
    }
}