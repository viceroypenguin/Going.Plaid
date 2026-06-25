namespace Going.Plaid.Entity;

/// <summary>
/// <para>Indicates whether the provided name matches the email address according to the KYC name-matches-email inference result if known.</para>
/// </summary>
public enum RiskCheckEmailName
{
	/// <summary>
	/// <para>"The user's profile does not contain the required user inputs to determine a match."</para>
	/// </summary>
	[EnumMember(Value = "no_input")]
	NoInput,

	/// <summary>
	/// <para>"The email does not contain any name identifiers, and a match could not be determined."</para>
	/// </summary>
	[EnumMember(Value = "indeterminate")]
	Indeterminate,

	/// <summary>
	/// <para>"The email's name identifiers do not match the user's name."</para>
	/// </summary>
	[EnumMember(Value = "no_match")]
	NoMatch,

	/// <summary>
	/// <para>"The email's name identifiers partially match the user's name."</para>
	/// </summary>
	[EnumMember(Value = "partial_match")]
	PartialMatch,

	/// <summary>
	/// <para>"The email's name identifiers match the user's name."</para>
	/// </summary>
	[EnumMember(Value = "match")]
	Match,

	/// <summary>
	/// <para>"Field could not be verified against available sources."</para>
	/// </summary>
	[EnumMember(Value = "no_data")]
	NoData,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
