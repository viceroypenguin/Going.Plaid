namespace Going.Plaid.Entity;

/// <summary>
/// <para>ISO-3166-1 alpha-2 country code standard.</para>
/// </summary>
public enum CountryCode
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "US")]
	Us,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "GB")]
	Gb,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ES")]
	Es,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "NL")]
	Nl,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "FR")]
	Fr,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "IE")]
	Ie,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "CA")]
	Ca,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DE")]
	De,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "IT")]
	It,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PL")]
	Pl,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DK")]
	Dk,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "NO")]
	No,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SE")]
	Se,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "EE")]
	Ee,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "LT")]
	Lt,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "LV")]
	Lv,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PT")]
	Pt,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "BE")]
	Be,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
