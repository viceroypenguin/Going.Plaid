namespace Going.Plaid.Entity;

/// <summary>
/// <para>The version of network insights</para>
/// </summary>
public enum NetworkInsightsVersion
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "NI1")]
	Ni1,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
