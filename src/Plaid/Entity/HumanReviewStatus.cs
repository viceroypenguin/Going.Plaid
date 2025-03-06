namespace Going.Plaid.Entity;

/// <summary>
/// <para>The outcome of the human review check, when available. The following values are possible:</para>
/// </summary>
public enum HumanReviewStatus
{
	/// <summary>
	/// <para>The document passed the check.</para>
	/// </summary>
	[EnumMember(Value = "success")]
	Success,

	/// <summary>
	/// <para>The document failed the check.</para>
	/// </summary>
	[EnumMember(Value = "failed")]
	Failed,

	/// <summary>
	/// <para>The document was submitted, but the document specialist review was not completed in time.</para>
	/// </summary>
	[EnumMember(Value = "no_data")]
	NoData,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
