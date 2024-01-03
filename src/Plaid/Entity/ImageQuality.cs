namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public enum ImageQuality
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "high")]
	High,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "medium")]
	Medium,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "low")]
	Low,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
