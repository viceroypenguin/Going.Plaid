using Newtonsoft.Json;

namespace Gigobyte.Plaid.Contract
{
    /// <summary>
    /// Represents a Plaid Connect service request.
    /// </summary>
    public class PlaidConnectRequest
    {
        /// <summary>
        /// Gets or sets your Plaid client identifier.
        /// </summary>
        /// <value>The client identifier.</value>
        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets your Plaid account secret.
        /// </summary>
        /// <value>The secret.</value>
        [JsonProperty("secret")]
        public string Secret { get; set; }

        /// <summary>
        /// Gets or sets the user's credentials.
        /// </summary>
        /// <value>The credential.</value>
        [JsonProperty("credentials")]
        public Credential Credential { get; set; }

        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        /// <value>The access token.</value>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the institution type.
        /// </summary>
        /// <value>The institution type.</value>
        [JsonProperty("type")]
        public string InstitutionType { get; set; }

        /// <summary>
        /// Gets or sets the options.
        /// </summary>
        /// <value>The options.</value>
        [JsonProperty("options")]
        public ConnectOptions Options { get; set; }

        /// <summary>
        /// Gets or sets the user's account pin.
        /// </summary>
        /// <value>The pin.</value>
        [JsonProperty("pin")]
        public string Pin { get; set; }

        /// <summary>
        /// Gets or sets the MFA information.
        /// </summary>
        /// <value>The mfa.</value>
        [JsonProperty("mfa")]
        public string Mfa { get; set; }
    }
}