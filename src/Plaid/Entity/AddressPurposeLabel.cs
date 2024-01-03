namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public enum AddressPurposeLabel
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "residential")]
	Residential,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "commercial")]
	Commercial,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "no_data")]
	NoData,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
