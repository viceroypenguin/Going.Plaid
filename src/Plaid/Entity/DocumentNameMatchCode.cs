namespace Going.Plaid.Entity;

/// <summary>
/// <para>A match summary describing the cross comparison between the subject's name, extracted from the document image, and the name they separately provided to identity verification attempt.</para>
/// </summary>
public enum DocumentNameMatchCode
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
