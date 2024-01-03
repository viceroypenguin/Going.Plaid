namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorStripeBankAccountTokenCreateResponse defines the response schema for <c>/processor/stripe/bank_account/create</c></para>
/// </summary>
public record ProcessorStripeBankAccountTokenCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>A token that can be sent to Stripe for use in making API calls to Plaid</para>
	/// </summary>
	[JsonPropertyName("stripe_bank_account_token")]
	public string StripeBankAccountToken { get; init; } = default!;

}
