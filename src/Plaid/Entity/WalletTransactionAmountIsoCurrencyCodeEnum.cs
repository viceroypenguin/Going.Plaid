namespace Going.Plaid.Entity;

/// <summary>
/// <para>The ISO-4217 currency code of the transaction. Currently, only <c>"GBP"</c> is supported.</para>
/// </summary>
public enum WalletTransactionAmountIsoCurrencyCodeEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "GBP")]
	Gbp,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}