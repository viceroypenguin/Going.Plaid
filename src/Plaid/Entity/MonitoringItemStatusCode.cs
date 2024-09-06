namespace Going.Plaid.Entity;

/// <summary>
/// <para>Enum for the status of the Item's insights</para>
/// </summary>
public enum MonitoringItemStatusCode
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "AVAILABLE")]
	Available,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PENDING")]
	Pending,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ITEM_NOT_SUPPORTED")]
	ItemNotSupported,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ITEM_LOGIN_REQUIRED")]
	ItemLoginRequired,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
