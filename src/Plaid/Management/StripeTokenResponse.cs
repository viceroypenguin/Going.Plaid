using System.Text.Json.Serialization;

namespace Going.Plaid.Management
{
	/// <summary>
	/// Represents a response from plaid's '<c>/processor/stripe/bank_account_token/create</c>' endpoint. Exchange a Link access_token for an Stripe API stripe_bank_account_token.
	/// </summary>
	/// <seealso cref="Going.Plaid.ResponseBase" />
	public record StripeTokenResponse : ResponseBase
	{
		/// <summary>
		/// Gets or sets the access token.
		/// </summary>
		/// <value>The access token.</value>
		[JsonPropertyName("stripe_bank_account_token")]
		public string StripeBankAccountToken { get; init; } = string.Empty;
	}
}
