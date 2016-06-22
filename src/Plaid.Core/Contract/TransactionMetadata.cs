using Newtonsoft.Json;

namespace Gigobyte.Plaid.Contract
{
    /// <summary>
    /// Represents a <see cref="Transaction"/> meta data.
    /// </summary>
    [JsonObject]
    public class TransactionMetadata
    {
        /// <summary>
        /// Gets or sets the merchant's location.
        /// </summary>
        /// <value>The location.</value>
        public Location Location { get; set; }

        /// <summary>
        /// Gets or sets the phone number associated with the merchant.
        /// </summary>
        /// <value>The phone number.</value>
        [JsonProperty("contact")]
        public string Phone { get; set; }
    }
}