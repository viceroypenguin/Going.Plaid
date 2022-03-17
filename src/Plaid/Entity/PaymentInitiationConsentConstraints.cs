namespace Going.Plaid.Entity;

/// <summary>
/// <para>Limitations that will be applied to payments initiated using the payment consent.</para>
/// </summary>
public class PaymentInitiationConsentConstraints
{
	/// <summary>
	/// <para>Life span for the payment consent. After the <c>to</c> date the payment consent expires and can no longer be used for payment initiation.</para>
	/// </summary>
	[JsonPropertyName("valid_date_time")]
	public Entity.PaymentConsentValidDateTime ValidDateTime { get; set; } = default!;

	/// <summary>
	/// <para>Maximum amount of a single payment initiated using the payment consent.</para>
	/// </summary>
	[JsonPropertyName("max_payment_amount")]
	public Entity.PaymentConsentMaxPaymentAmount MaxPaymentAmount { get; set; } = default!;

	/// <summary>
	/// <para>A list of amount limitations per period of time.</para>
	/// </summary>
	[JsonPropertyName("periodic_amounts")]
	public IReadOnlyList<Entity.PaymentConsentPeriodicAmount> PeriodicAmounts { get; set; } = default!;
}