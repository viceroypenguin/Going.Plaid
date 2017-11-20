using Newtonsoft.Json;

namespace Acklann.Plaid.Management
{
    /// <summary>
    /// Represents a response from plaid's '/item/access_token/invalidate'. You can use the '/item/access_token/invalidate' endpoint to rotate the access_token associated with an Item. The endpoint returns a new access_token and immediately invalidates the previous access_token.
    /// </summary>
    /// <seealso cref="Acklann.Plaid.ResponseBase" />
    public class RotateAccessTokenResponse : ResponseBase
    {
        /// <summary>
        /// Gets or sets the new access token.
        /// </summary>
        /// <value>The new access token.</value>
        [JsonProperty("new_access_token")]
        public string NewAccessToken { get; set; }
    }
}