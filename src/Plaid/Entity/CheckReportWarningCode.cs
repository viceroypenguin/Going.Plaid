namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public enum CheckReportWarningCode
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "IDENTITY_UNAVAILABLE")]
	IdentityUnavailable,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TRANSACTIONS_UNAVAILABLE")]
	TransactionsUnavailable,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "USER_FRAUD_ALERT")]
	UserFraudAlert,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
