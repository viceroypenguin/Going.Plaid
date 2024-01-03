namespace Going.Plaid.Entity;

/// <summary>
/// <para>Current employment status.</para>
/// </summary>
public enum EmploymentVerificationStatus
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "EMPLOYMENT_STATUS_ACTIVE")]
	EmploymentStatusActive,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "EMPLOYMENT_STATUS_INACTIVE")]
	EmploymentStatusInactive,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
