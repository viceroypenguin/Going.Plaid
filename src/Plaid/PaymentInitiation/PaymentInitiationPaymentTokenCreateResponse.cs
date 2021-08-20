namespace Going.Plaid.PaymentInitiation;

/// <summary>
/// <para>PaymentInitiationPaymentTokenCreateResponse defines the response schema for <c>/payment_initiation/payment/token/create</c></para>
/// </summary>
public record PaymentInitiationPaymentTokenCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>A <c>payment_token</c> that can be provided to Link initialization to enter the payment initiation flow</para>
	/// </summary>
	[JsonPropertyName("payment_token")]
	public string PaymentToken { get; init; } = default!;

	/// <summary>
	/// <para>The date and time at which the token will expire, in ISO 8601 format. A <c>payment_token</c> expires after 15 minutes.</para>
	/// </summary>
	[JsonPropertyName("payment_token_expiration_time")]
	public DateTimeOffset PaymentTokenExpirationTime { get; init; } = default!;
}