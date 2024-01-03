namespace Going.Plaid.Entity;

/// <summary>
/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
/// </summary>
public enum MatchSummaryCode
{
	/// <summary>
	/// <para>indicates that the provided input data was a strong match against external data.</para>
	/// </summary>
	[EnumMember(Value = "match")]
	Match,

	/// <summary>
	/// <para>indicates the data approximately matched against external data. For example, "Knope" vs. "Knope-Wyatt" for last name.</para>
	/// </summary>
	[EnumMember(Value = "partial_match")]
	PartialMatch,

	/// <summary>
	/// <para>indicates that Plaid was able to perform a check against an external data source and it did not match the provided input data.</para>
	/// </summary>
	[EnumMember(Value = "no_match")]
	NoMatch,

	/// <summary>
	/// <para>indicates that Plaid was unable to find external data to compare against the provided input data.</para>
	/// </summary>
	[EnumMember(Value = "no_data")]
	NoData,

	/// <summary>
	/// <para>indicates that Plaid was unable to perform a check because no information was provided for this field by the end user.</para>
	/// </summary>
	[EnumMember(Value = "no_input")]
	NoInput,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
