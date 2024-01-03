namespace Going.Plaid.Entity;

/// <summary>
/// <para>The warning code identifies a specific kind of warning. <c>OWNERS_UNAVAILABLE</c> indicates that account-owner information is not available.<c>INVESTMENTS_UNAVAILABLE</c> indicates that Investments specific information is not available. <c>TRANSACTIONS_UNAVAILABLE</c> indicates that transactions information associated with Credit and Depository accounts are unavailable.</para>
/// </summary>
public enum WarningWarningCodeEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "OWNERS_UNAVAILABLE")]
	OwnersUnavailable,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INVESTMENTS_UNAVAILABLE")]
	InvestmentsUnavailable,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TRANSACTIONS_UNAVAILABLE")]
	TransactionsUnavailable,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
