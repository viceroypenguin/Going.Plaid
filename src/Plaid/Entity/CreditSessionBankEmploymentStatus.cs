namespace Going.Plaid.Entity;

/// <summary>
/// <para>Status of the Bank Employment Link session.</para>
/// </summary>
public enum CreditSessionBankEmploymentStatus
{
	/// <summary>
	/// <para>User has approved and verified their employment.</para>
	/// </summary>
	[EnumMember(Value = "APPROVED")]
	Approved,

	/// <summary>
	/// <para>We attempted, but were unable to find any employment in the connected account.</para>
	/// </summary>
	[EnumMember(Value = "NO_EMPLOYERS_FOUND")]
	NoEmployersFound,

	/// <summary>
	/// <para>The user explicitly indicated that they did not see their current or previous employer in the list of employer names found.</para>
	/// </summary>
	[EnumMember(Value = "EMPLOYER_NOT_LISTED")]
	EmployerNotListed,

	/// <summary>
	/// <para>The user began the bank employment portion of the link flow.</para>
	/// </summary>
	[EnumMember(Value = "STARTED")]
	Started,

	/// <summary>
	/// <para>The user encountered an internal error.</para>
	/// </summary>
	[EnumMember(Value = "INTERNAL_ERROR")]
	InternalError,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
