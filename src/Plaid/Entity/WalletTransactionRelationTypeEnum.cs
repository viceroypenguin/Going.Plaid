namespace Going.Plaid.Entity;

/// <summary>
/// <para>The type of the transaction.</para>
/// </summary>
public enum WalletTransactionRelationTypeEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PAYOUT")]
	Payout,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "RETURN")]
	Return,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "REFUND")]
	Refund,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "FUNDS_SWEEP")]
	FundsSweep,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
