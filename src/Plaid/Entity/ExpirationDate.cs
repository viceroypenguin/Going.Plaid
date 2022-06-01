namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public enum ExpirationDate
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "not_expired")]
	NotExpired,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "expired")]
	Expired,

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