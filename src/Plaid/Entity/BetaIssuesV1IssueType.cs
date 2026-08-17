namespace Going.Plaid.Entity;

/// <summary>
/// <para>The customer-facing category of an issue.</para>
/// </summary>
public enum BetaIssuesV1IssueType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ERROR")]
	Error,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
