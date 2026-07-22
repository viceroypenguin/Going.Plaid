namespace Going.Plaid.Entity;

/// <summary>
/// <para>The stage in the lending lifecycle for which the report is being retrieved.</para>
/// </summary>
public enum CraReportDecisionStage
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PREQUALIFICATION")]
	Prequalification,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DECISIONING")]
	Decisioning,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SERVICING")]
	Servicing,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
