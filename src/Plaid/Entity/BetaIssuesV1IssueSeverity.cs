namespace Going.Plaid.Entity;

/// <summary>
/// <para>The customer-facing severity of an issue.</para>
/// </summary>
public enum BetaIssuesV1IssueSeverity
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "CRITICAL")]
	Critical,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "HIGH")]
	High,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "MEDIUM")]
	Medium,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "LOW")]
	Low,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
