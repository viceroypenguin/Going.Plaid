namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public enum DocumentAuthenticityMatchCode
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "match")]
	Match,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "partial_match")]
	PartialMatch,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "no_match")]
	NoMatch,

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