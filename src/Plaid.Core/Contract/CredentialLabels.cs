using Newtonsoft.Json;

namespace Gigobyte.Plaid.Contract
{
    /// <summary>
    /// Represents an <see cref="Institution"/> authentication form labels.
    /// </summary>
    [JsonObject]
    public struct CredentialLabels
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the institution label for the field.
        /// </summary>
        /// <value>The label.</value>
        [JsonProperty("password")]
        public string Password { get; set; }
    }
}