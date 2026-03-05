namespace Going.Plaid.Entity;

/// <summary>
/// <para>The version of the base FICO score model.</para>
/// </summary>
public enum CraPartnerInsightsBaseFicoScoreVersion
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "8")]
	_8,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "9")]
	_9,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "10T")]
	_10t,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
