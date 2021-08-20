namespace Going.Plaid.Entity;

/// <summary>
/// <para>The ISO-4217 currency code of the payment. For standing orders, <c>"GBP"</c> must be used.</para>
/// </summary>
public enum PaymentAmountCurrencyEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "GBP")]
	Gbp,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "EUR")]
	Eur,
}