namespace Going.Plaid.Entity;

/// <summary>
/// <para>The version of Prism Insights. If not specified, will default to v3.</para>
/// </summary>
public enum PrismInsightsVersion
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "3")]
	_3,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
