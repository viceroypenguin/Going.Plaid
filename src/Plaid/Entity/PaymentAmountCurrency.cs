namespace Going.Plaid.Entity;

/// <summary>
/// <para>The ISO-4217 currency code of the payment. For standing orders and payment consents, <c>"GBP"</c> must be used. For Poland, Denmark, Sweden and Norway, only the local currency is currently supported.</para>
/// </summary>
public enum PaymentAmountCurrency
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
	/// 
	/// </summary>
	[EnumMember(Value = "PLN")]
	Pln,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SEK")]
	Sek,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DKK")]
	Dkk,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "NOK")]
	Nok,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
