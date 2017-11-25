using Newtonsoft.Json;

namespace Acklann.Plaid.Management
{
    /// <summary>
    /// Represents a request for plaid's '/item/public_token/exchange' endpoint. Exchange a Link public_token for an API access_token.
    /// </summary>
    /// <seealso cref="Acklann.Plaid.SerializableContent" />
    public class ExchangeTokenRequest : SerializableContent
    {
        /// <summary>
        /// Gets or sets the public_token.
        /// </summary>
        /// <value>The public token.</value>
        [JsonProperty("public_token")]
        public string PublicToken { get; set; }

        /// <summary>
        /// Gets or sets the client identifier.
        /// </summary>
        /// <value>The client identifier.</value>
        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the secret.
        /// </summary>
        /// <value>The secret.</value>
        [JsonProperty("secret")]
        public string Secret { get; set; }
    }
}