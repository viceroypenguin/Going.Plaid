using Newtonsoft.Json;

namespace Going.Plaid.Management
{
	/// <summary>
	/// Represents a response from plaid's '<c>/item/access_token/invalidate</c>'. You can use the '<c>/item/access_token/invalidate</c>' endpoint to rotate the access_token associated with an Item. The endpoint returns a new access_token and immediately invalidates the previous access_token.
	/// </summary>
	/// <seealso cref="Going.Plaid.ResponseBase" />
	public record RotateAccessTokenResponse : ResponseBase
	{
		/// <summary>
		/// The new access token.
		/// </summary>
		[JsonProperty("new_access_token")]
		public string NewAccessToken { get; init; } = null!;
	}
}
