namespace Going.Plaid.Entity;

/// <summary>
/// <para>Risk level for the given risk check type.</para>
/// </summary>
public enum RiskLevel
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "low")]
	Low,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "medium")]
	Medium,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "high")]
	High,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
