namespace Going.Plaid.Entity;

/// <summary>
/// <para>The amount and currency of the fraud or attempted fraud.</para>
/// <para><c>fraud_amount</c> should be omitted to indicate an unknown fraud amount.</para>
/// </summary>
public class FraudAmount
{
	/// <summary>
	/// <para>An ISO-4217 currency code.</para>
	/// </summary>
	[JsonPropertyName("iso_currency_code")]
	public Entity.IsoCurrencyCode IsoCurrencyCode { get; set; } = default!;

	/// <summary>
	/// <para>The amount value.</para>
	/// <para>This value can be 0 to indicate no money was lost.</para>
	/// <para>Must not contain more than two digits of precision (e.g., <c>1.23</c>).</para>
	/// </summary>
	[JsonPropertyName("value")]
	public decimal Value { get; set; } = default!;

}
