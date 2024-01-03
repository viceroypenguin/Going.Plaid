namespace Going.Plaid.PaymentInitiation;

/// <summary>
/// <para>PaymentInitiationRecipientListResponse defines the response schema for <c>/payment_initiation/recipient/list</c></para>
/// </summary>
public record PaymentInitiationRecipientListResponse : ResponseBase
{
	/// <summary>
	/// <para>An array of payment recipients created for Payment Initiation</para>
	/// </summary>
	[JsonPropertyName("recipients")]
	public IReadOnlyList<Entity.PaymentInitiationRecipient> Recipients { get; init; } = default!;

}
