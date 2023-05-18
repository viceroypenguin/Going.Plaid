namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information about the comparison between the selfie and the document (if documentary verification also ran).</para>
/// </summary>
public enum SelfieAnalysisDocumentComparison
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "match")]
	Match,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "no_match")]
	NoMatch,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "no_input")]
	NoInput,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}