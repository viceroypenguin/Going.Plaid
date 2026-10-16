namespace Going.Plaid.Entity;

/// <summary>
/// <para>The version of Prism FirstDetect. If <c>prism_versions</c> is omitted entirely, FirstDetect v3 is generated when your client's configured default Prism version is v3 or no default is configured; it is not generated if the default is v4 or v4.1. If other Prism versions are specified but this one is not, this product is not generated.</para>
/// </summary>
public enum PrismFirstDetectVersion
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
