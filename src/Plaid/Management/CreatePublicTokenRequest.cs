using Newtonsoft.Json;

namespace Acklann.Plaid.Management
{
    /// <summary>
    /// Represents a request for plaid's '/item/public_token/create' endpoint. Create a public_token from an access_token for use with Plaid LInk's update mode.
    /// </summary>
    /// <seealso cref="Acklann.Plaid.SerializableContent" />
    public class CreatePublicTokenRequest : SerializableContent
    {
        /// <summary>
        /// Gets or sets the access_token.
        /// </summary>
        /// <value>The access token.</value>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

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