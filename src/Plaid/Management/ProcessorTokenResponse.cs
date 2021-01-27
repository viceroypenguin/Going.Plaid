using System.Text.Json.Serialization;

namespace Going.Plaid.Management
{
	/// <summary>
	/// Represents a response from plaid's '<c>/processor/stripe/bank_account_token/create</c>' endpoint. Exchange a Link <see cref="ExchangeTokenResponse.AccessToken"/> for a <see cref="ProcessorTokenResponse.ProcessorToken"/>.
	/// </summary>
	/// <seealso cref="Going.Plaid.ResponseBase" />
	public record ProcessorTokenResponse : ResponseBase
	{
		/// <summary>
		/// The <c>processor_token</c> that can then be used by the Plaid partner to make API requests
		/// </summary>
		[JsonPropertyName("processor_token")]
		public string ProcessorToken { get; init; } = string.Empty;
	}
}
