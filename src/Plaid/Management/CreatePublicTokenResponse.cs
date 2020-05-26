using Newtonsoft.Json;

namespace Acklann.Plaid.Management
{
    /// <summary>
    /// Represents a response from plaid's '/item/public_token/create' endpoint. Create a public_token from an access_token for use with Plaid LInk's update mode.
    /// </summary>
    /// <seealso cref="Acklann.Plaid.ResponseBase" />
    public class CreatePublicTokenResponse : ResponseBase
    {
        /// <summary>
        /// Gets or sets the <see cref="Entity.Item"/> identifier.
        /// </summary>
        /// <value>The item identifier.</value>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// Gets or sets the public token.
        /// </summary>
        /// <value>The public token.</value>
        [JsonProperty("public_token")]
        public string PublicToken { get; set; }
    }
}