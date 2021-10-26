namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public enum ConnectedApplicationProductDataTypesEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ACCOUNT_BALANCE")]
	AccountBalance,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ACCOUNT_USER_INFO")]
	AccountUserInfo,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ACCOUNT_TRANSACTIONS")]
	AccountTransactions,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "unknown")]
	Unknown,
}