namespace Going.Plaid.Entity;

/// <summary>
/// <para>Result of payee verification check for EUR payouts. Payee verification checks whether the payee name provided matches the account holder name at the destination institution.</para>
/// </summary>
public enum WalletTransactionPayeeVerificationStatus
{
	/// <summary>
	/// <para>The payee name fully matches the account holder.</para>
	/// </summary>
	[EnumMember(Value = "FULL_MATCH")]
	FullMatch,

	/// <summary>
	/// <para>The payee name partially matches the account holder.</para>
	/// </summary>
	[EnumMember(Value = "PARTIAL_MATCH")]
	PartialMatch,

	/// <summary>
	/// <para>The payee name does not match the account holder.</para>
	/// </summary>
	[EnumMember(Value = "NO_MATCH")]
	NoMatch,

	/// <summary>
	/// <para>An error occurred during payee verification.</para>
	/// </summary>
	[EnumMember(Value = "ERROR")]
	Error,

	/// <summary>
	/// <para>Payee verification could not be performed.</para>
	/// </summary>
	[EnumMember(Value = "CHECK_NOT_POSSIBLE")]
	CheckNotPossible,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
