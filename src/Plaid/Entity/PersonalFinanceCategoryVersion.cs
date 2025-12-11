namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public enum PersonalFinanceCategoryVersion
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "v1")]
	V1,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "v2")]
	V2,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
