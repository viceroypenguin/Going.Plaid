namespace Going.Plaid.Entity;

/// <summary>
/// <para>Metadata that captures what specific payment configurations an institution supports when making Payment Initiation requests.</para>
/// </summary>
public record PaymentInitiationMetadata
{
	/// <summary>
	/// <para>Indicates whether the institution supports payments from a different country.</para>
	/// </summary>
	[JsonPropertyName("supports_international_payments")]
	public bool SupportsInternationalPayments { get; init; } = default!;

	/// <summary>
	/// <para>Indicates whether the institution supports SEPA Instant payments.</para>
	/// </summary>
	[JsonPropertyName("supports_sepa_instant")]
	public bool SupportsSepaInstant { get; init; } = default!;

	/// <summary>
	/// <para>A mapping of currency to maximum payment amount (denominated in the smallest unit of currency) supported by the institution.</para>
	/// <para>Example: <c>{"GBP": "10000"}</c></para>
	/// </summary>
	[JsonPropertyName("maximum_payment_amount")]
	public IReadOnlyDictionary<string, string> MaximumPaymentAmount { get; init; } = default!;

	/// <summary>
	/// <para>Indicates whether the institution supports returning refund details when initiating a payment.</para>
	/// </summary>
	[JsonPropertyName("supports_refund_details")]
	public bool SupportsRefundDetails { get; init; } = default!;

	/// <summary>
	/// <para>Metadata specifically related to valid Payment Initiation standing order configurations for the institution.</para>
	/// </summary>
	[JsonPropertyName("standing_order_metadata")]
	public Entity.PaymentInitiationStandingOrderMetadata? StandingOrderMetadata { get; init; } = default!;
}