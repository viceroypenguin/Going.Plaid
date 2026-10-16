namespace Going.Plaid.Entity;

/// <summary>
/// <para>The Social Security Administration (SSA) match result for the person's name, date of birth, and Social Security number.</para>
/// </summary>
public enum KYCCheckSSAMatchStatus
{
	/// <summary>
	/// <para>indicates that the provided information matches SSA records.</para>
	/// </summary>
	[EnumMember(Value = "match")]
	Match,

	/// <summary>
	/// <para>indicates that the provided information does not match SSA records.</para>
	/// </summary>
	[EnumMember(Value = "no_match")]
	NoMatch,

	/// <summary>
	/// <para>indicates that no SSA match result is available.</para>
	/// </summary>
	[EnumMember(Value = "no_data")]
	NoData,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
