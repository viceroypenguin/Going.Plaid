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

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "unknown")]
	Unknown,
}