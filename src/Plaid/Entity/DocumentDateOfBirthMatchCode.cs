namespace Going.Plaid.Entity;

/// <summary>
/// <para>A match summary describing the cross comparison between the subject's date of birth, extracted from the document image, and the date of birth they separately provided to the identity verification attempt.</para>
/// </summary>
public enum DocumentDateOfBirthMatchCode
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
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}