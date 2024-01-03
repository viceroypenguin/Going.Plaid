namespace Going.Plaid.Entity;

/// <summary>
/// <para>An enum indicating the match type between two Beacon Users.</para>
/// </summary>
public enum BeaconMatchSummaryCode
{
	/// <summary>
	/// <para>indicates that the provided input data was a strong match against the other Beacon User.</para>
	/// </summary>
	[EnumMember(Value = "match")]
	Match,

	/// <summary>
	/// <para>indicates the data approximately matched the other Beacon User. For example, "Knope" vs. "Knope-Wyatt" for last name.</para>
	/// </summary>
	[EnumMember(Value = "partial_match")]
	PartialMatch,

	/// <summary>
	/// <para>indicates that Plaid was able to compare this field against the other Beacon User and it did not match the provided input data.</para>
	/// </summary>
	[EnumMember(Value = "no_match")]
	NoMatch,

	/// <summary>
	/// <para>indicates that Plaid was unable to compare this field against the original Beacon User because the field was not present in one of the Beacon Users.</para>
	/// </summary>
	[EnumMember(Value = "no_data")]
	NoData,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
