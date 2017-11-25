using Newtonsoft.Json;

namespace Acklann.Plaid
{
    /// <summary>
    /// Provides methods and properties for making a standard request.
    /// </summary>
    /// <seealso cref="Acklann.Plaid.SerializableContent" />
    public abstract class RequestBase : SerializableContent
    {
        /// <summary>
        /// Gets or sets the secret.
        /// </summary>
        /// <value>The secret.</value>
        [JsonProperty("secret")]
        public string Secret { get; set; }

        /// <summary>
        /// Gets or sets the client_id.
        /// </summary>
        /// <value>The client identifier.</value>
        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the access_token.
        /// </summary>
        /// <value>The access token.</value>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
    }
}