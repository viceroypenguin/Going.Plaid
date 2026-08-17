namespace Going.Plaid.Entity;

/// <summary>
/// <para>How an issue was considered resolved. <c>MANUAL_RESOLUTION</c> indicates Plaid's engineering team has reviewed the issue and mitigated its impact. Issues that are manually resolved may still have a small number of occurrences. <c>AUTOMATED_RESOLUTION</c> indicates the error has not recently occurred and was automatically closed.</para>
/// </summary>
public enum BetaIssuesV1IssueResolutionType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "MANUAL_RESOLUTION")]
	ManualResolution,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "AUTOMATED_RESOLUTION")]
	AutomatedResolution,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
