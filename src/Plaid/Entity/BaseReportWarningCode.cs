namespace Going.Plaid.Entity;

/// <summary>
/// <para>The warning code identifies a specific kind of warning.</para>
/// </summary>
public enum BaseReportWarningCode
{
	/// <summary>
	/// <para>Account-owner information is not available.</para>
	/// </summary>
	[EnumMember(Value = "IDENTITY_UNAVAILABLE")]
	IdentityUnavailable,

	/// <summary>
	/// <para>Transactions information associated with Credit and Depository accounts are unavailable.</para>
	/// </summary>
	[EnumMember(Value = "TRANSACTIONS_UNAVAILABLE")]
	TransactionsUnavailable,

	/// <summary>
	/// <para>The User has placed a fraud alert on their Plaid Check consumer report due to suspected fraud. Note: when a fraud alert is in place, the recipient of the consumer report has an obligation to verify the consumer’s identity.</para>
	/// </summary>
	[EnumMember(Value = "USER_FRAUD_ALERT")]
	UserFraudAlert,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
