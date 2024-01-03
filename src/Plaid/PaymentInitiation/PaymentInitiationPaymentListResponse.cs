namespace Going.Plaid.PaymentInitiation;

/// <summary>
/// <para>PaymentInitiationPaymentListResponse defines the response schema for <c>/payment_initiation/payment/list</c></para>
/// </summary>
public record PaymentInitiationPaymentListResponse : ResponseBase
{
	/// <summary>
	/// <para>An array of payments that have been created, associated with the given <c>client_id</c>.</para>
	/// </summary>
	[JsonPropertyName("payments")]
	public IReadOnlyList<Entity.PaymentInitiationPayment> Payments { get; init; } = default!;

	/// <summary>
	/// <para>The value that, when used as the optional <c>cursor</c> parameter to <c>/payment_initiation/payment/list</c>, will return the next unreturned payment as its first payment.</para>
	/// </summary>
	[JsonPropertyName("next_cursor")]
	public DateTimeOffset? NextCursor { get; init; } = default!;

}
