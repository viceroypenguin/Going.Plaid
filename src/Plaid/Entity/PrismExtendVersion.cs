namespace Going.Plaid.Entity;

/// <summary>
/// <para>The version of Prism Extend</para>
/// </summary>
public enum PrismExtendVersion
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "4")]
	_4,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
