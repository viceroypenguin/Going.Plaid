namespace Going.Plaid.Entity;

/// <summary>
/// <para>The outcome of checking the particular field against state databases.</para>
/// </summary>
public enum AAMVAMatchResult
{
	/// <summary>
	/// <para>The field is an exact match with the state database.</para>
	/// </summary>
	[EnumMember(Value = "match")]
	Match,

	/// <summary>
	/// <para>The field is not an exact match with the state database.</para>
	/// </summary>
	[EnumMember(Value = "no_match")]
	NoMatch,

	/// <summary>
	/// <para>The field was unable to be checked against state databases.</para>
	/// </summary>
	[EnumMember(Value = "no_data")]
	NoData,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
