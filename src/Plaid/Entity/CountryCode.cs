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
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "unknown")]
	Unknown,
}