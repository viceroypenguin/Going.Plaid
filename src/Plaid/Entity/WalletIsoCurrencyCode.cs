namespace Going.Plaid.Entity;

/// <summary>
/// <para>An ISO-4217 currency code, used with e-wallets and transactions.</para>
/// </summary>
public enum WalletIsoCurrencyCode
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
	[EnumMember(Value = "undefined")]
	Undefined,

}
