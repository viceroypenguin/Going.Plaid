namespace Going.Plaid.Entity;

/// <summary>
/// <para>The type of of the transaction. Currently, only <c>"PAYOUT"</c> is supported.</para>
/// </summary>
public enum WalletTransactionTypeEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAYOUT")]
	Payout,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}