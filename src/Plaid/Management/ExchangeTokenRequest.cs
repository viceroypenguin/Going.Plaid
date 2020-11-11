using System.Text.Json.Serialization;

namespace Going.Plaid.Management
{
	/// <summary>
	/// Represents a request for plaid's '<c>/item/public_token/exchange</c>' endpoint. Exchange a Link public_token for an API access_token.
	/// </summary>
	/// <seealso cref="RequestBase" />
	public class ExchangeTokenRequest : RequestBase
	{
		/// <summary>
		/// The Public Token returned by the Plaid Link Tool.
		/// </summary>
		[JsonPropertyName("public_token")]
		public string PublicToken { get; set; } = null!;
	}
}
