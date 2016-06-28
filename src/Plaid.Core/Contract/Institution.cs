using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Gigobyte.Plaid.Contract
{
    /// <summary>
    /// Represents an financial institution.
    /// </summary>
    [JsonObject]
    public class Institution
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>The currency.</value>
        [JsonProperty("currencyCode")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the credential fields label.
        /// </summary>
        /// <value>The labels.</value>
        [JsonProperty("credentials")]
        public CredentialLabels Labels { get; set; }

        /// <summary>
        /// Gets or sets the logo byte data.
        /// </summary>
        /// <value>The logo byte data.</value>
        [JsonProperty("logo")]
        public string LogoByteData { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance requires Multi-factor
        /// authentication (MFA).
        /// </summary>
        /// <value><c>true</c> if this instance has mfa; otherwise, <c>false</c>.</value>
        [JsonProperty("has_mfa")]
        public bool HasMFA { get; set; }

        /// <summary>
        /// Gets or sets the mfa options.
        /// </summary>
        /// <value>The mfa.</value>
        [JsonProperty("mfa")]
        public string[] Mfa { get; set; }

        /// <summary>
        /// Gets or sets the supported plaid products.
        /// </summary>
        /// <value>The products.</value>
        [JsonProperty("products")]
        public JToken Products { get; set; }
    }
}