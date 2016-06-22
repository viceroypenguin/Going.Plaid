using Newtonsoft.Json;

namespace Gigobyte.Plaid.Contract
{
    /// <summary>
    /// Represents an <see cref="Account"/> metadata.
    /// </summary>
    [JsonObject]
    public class AccountMetadata
    {
        /// <summary>
        /// Gets or sets the account name.
        /// </summary>
        /// <value>The account name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the account limit.
        /// </summary>
        /// <value>The account limit.</value>
        [JsonProperty("limit")]
        public float Limit { get; set; }

        /// <summary>
        /// Gets or sets the last last few digits of the account number.
        /// </summary>
        /// <value>The account number last digits.</value>
        [JsonProperty("number")]
        public string Number { get; set; }
    }
}