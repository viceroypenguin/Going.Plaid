using System.Text.Json.Serialization;

namespace Going.Plaid.Sandbox
{
	/// <summary>
	/// Represents a response from plaid's '<c>/sandbox/public_token/create</c>' endpoint.
	/// The <c>/sandbox/public_token/create</c> endpoint allows you
	/// to create a valid public_token for an arbitrary institution ID, initial products, and test credentials
	/// </summary>
	/// <seealso cref="Going.Plaid.ResponseBase" />
	public record CreatePublicTokenResponse : ResponseBase
	{
		/// <summary>
		/// A public token that can be exchanged for an access token using <c>/item/public_token/exchange</c>
		/// </summary>
		[JsonPropertyName("public_token")]
		public string PublicToken { get; init; } = null!;
	}
}
