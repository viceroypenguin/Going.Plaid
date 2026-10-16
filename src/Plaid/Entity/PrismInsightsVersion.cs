namespace Going.Plaid.Entity;

/// <summary>
/// <para>The version of Prism Insights. If <c>prism_versions</c> is omitted entirely, your client's configured default Prism version is used (v3 if none is configured). If other Prism versions are specified but this one is not, this product is not generated.</para>
/// </summary>
public enum PrismInsightsVersion
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "4.1")]
	_41,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "4")]
	_4,

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
