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
	/// 
	/// </summary>
	[EnumMember(Value = "NO_EMPLOYERS_FOUND")]
	NoEmployersFound,

	/// <summary>
	/// <para>The user explicitly indicated that they did not see their current or previous employer in the list of employer names found.</para>
	/// </summary>
	[EnumMember(Value = "EMPLOYER_NOT_LISTED")]
	EmployerNotListed,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}