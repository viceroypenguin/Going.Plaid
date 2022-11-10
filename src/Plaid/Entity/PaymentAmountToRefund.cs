namespace Going.Plaid.Entity;

/// <summary>
/// <para>An amount to refund the payment partially. If this amount is not specified, the payment is refunded fully for the remaining amount.</para>
/// </summary>
public class PaymentAmountToRefund
{
	/// <summary>
	/// <para>The ISO-4217 currency code of the payment. For standing orders and payment consents, <c>"GBP"</c> must be used.</para>
	/// </summary>
	[JsonPropertyName("currency")]
	public Entity.PaymentAmountCurrency Currency { get; set; } = default!;

	/// <summary>
	/// <para>The amount of the payment. Must contain at most two digits of precision e.g. <c>1.23</c>. Minimum accepted value is <c>1</c>.</para>
	/// </summary>
	[JsonPropertyName("value")]
	public decimal Value { get; set; } = default!;
}