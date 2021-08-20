namespace Going.Plaid.Entity;

/// <summary>
/// <para>The type of balance to which the APR applies.</para>
/// </summary>
public enum AprAprTypeEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "balance_transfer_apr")]
	BalanceTransferApr,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "cash_apr")]
	CashApr,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "purchase_apr")]
	PurchaseApr,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "special")]
	Special,
}