namespace Going.Plaid.Entity;

/// <summary>
/// <para>Indicates whether the email address includes the date of birth or year of birth if known.</para>
/// </summary>
public enum RiskCheckEmailIncludesDateOfBirth
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "yes")]
	Yes,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "no")]
	No,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "no_data")]
	NoData,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
