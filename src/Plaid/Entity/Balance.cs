using Newtonsoft.Json;

namespace Acklann.Plaid.Entity
{
    /// <summary>
    /// Represents an account balance.
    /// </summary>
    public struct Balance
    {
        /// <summary>
        /// Gets or sets the current balance.
        /// </summary>
        /// <value>The current.</value>
        [JsonProperty("current")]
        public float Current { get; set; }

        /// <summary>
        /// Gets or sets the available balance.
        /// </summary>
        /// <value>The available.</value>
        [JsonProperty("available")]
        public float? Available { get; set; }

        /// <summary>
        /// Gets or sets the account limit.
        /// </summary>
        /// <value>The limit.</value>
        [JsonProperty("limit")]
        public float? Limit { get; set; }
    }
}