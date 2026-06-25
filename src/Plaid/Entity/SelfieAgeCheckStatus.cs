namespace Going.Plaid.Entity;

/// <summary>
/// <para>An enum indicating whether the reported age aligns with the estimated selfie capture age range.</para>
/// </summary>
public enum SelfieAgeCheckStatus
{
	/// <summary>
	/// <para>indicates that the reported age falls within the estimated selfie capture age range.</para>
	/// </summary>
	[EnumMember(Value = "match")]
	Match,

	/// <summary>
	/// <para>indicates that the reported age falls outside the estimated selfie capture age range, but is close enough that the result should be reviewed.</para>
	/// </summary>
	[EnumMember(Value = "warning")]
	Warning,

	/// <summary>
	/// <para>indicates that the reported age falls far outside the estimated selfie capture age range.</para>
	/// </summary>
	[EnumMember(Value = "no_match")]
	NoMatch,

	/// <summary>
	/// <para>indicates that there was not enough data available at age-estimation time to compare the reported age against the estimated selfie capture age range.</para>
	/// </summary>
	[EnumMember(Value = "no_data")]
	NoData,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
