namespace Going.Plaid.Entity;

/// <summary>
/// <para>Type of verification report.</para>
/// </summary>
public enum CraCheckReportVerificationGetReportType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "VOA")]
	Voa,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "EMPLOYMENT_REFRESH")]
	EmploymentRefresh,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
