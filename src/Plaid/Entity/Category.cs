using Newtonsoft.Json;

namespace Acklann.Plaid.Entity
{
    /// <summary>
    /// Represents a transaction's category.
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [JsonProperty("category_id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the group.
        /// </summary>
        /// <value>The group.</value>
        [JsonProperty("group")]
        public string Group { get; set; }

        /// <summary>
        /// Gets or sets the hierarchy or sub-categories.
        /// </summary>
        /// <value>The hierarchy.</value>
        [JsonProperty("hierarchy")]
        public string[] Hierarchy { get; set; }
    }
}