namespace Going.Plaid.Entity;

/// <summary>
/// <para>Defines consent payments limitations per period.</para>
/// </summary>
public class PaymentConsentPeriodicAmount
{
	/// <summary>
	/// <para>Maximum cumulative amount for all payments in the specified interval.</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public Entity.PaymentConsentPeriodicAmountAmount Amount { get; set; } = default!;

	/// <summary>
	/// <para>Payment consent periodic interval.</para>
	/// </summary>
	[JsonPropertyName("interval")]
	public Entity.PaymentConsentPeriodicInterval Interval { get; set; } = default!;

	/// <summary>
	/// <para>Where the payment consent period should start.</para>
	/// </summary>
	[JsonPropertyName("alignment")]
	public Entity.PaymentConsentPeriodicAlignment Alignment { get; set; } = default!;

}
