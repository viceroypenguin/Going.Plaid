using Newtonsoft.Json;

namespace Gigobyte.Plaid.Contract
{
    /// <summary>
    /// Represents a geographical location.
    /// </summary>
    [JsonObject]
    public class Location
    {
        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>The address.</value>
        [JsonProperty("address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>The city.</value>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>The state.</value>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        /// <value>The postal code.</value>
        [JsonProperty("zip")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the geo coordinates.
        /// </summary>
        /// <value>The coordinates.</value>
        [JsonProperty("coordinates")]
        public Coordinate Coordinates { get; set; }
    }
}