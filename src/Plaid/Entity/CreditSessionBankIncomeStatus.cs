namespace Going.Plaid.Entity;

/// <summary>
/// <para>The terminal status of the bank income verification.</para>
/// </summary>
public enum CreditSessionBankIncomeStatus
{
	/// <summary>
	/// <para>User has approved and verified their income</para>
	/// </summary>
	[EnumMember(Value = "APPROVED")]
	Approved,

	/// <summary>
	/// <para>We attempted, but were unable to find any income in the connected account.</para>
	/// </summary>
	[EnumMember(Value = "NO_DEPOSITS_FOUND")]
	NoDepositsFound,

	/// <summary>
	/// <para>The user explicitly indicated that they don't receive income in the connected account.</para>
	/// </summary>
	[EnumMember(Value = "USER_REPORTED_NO_INCOME")]
	UserReportedNoIncome,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}