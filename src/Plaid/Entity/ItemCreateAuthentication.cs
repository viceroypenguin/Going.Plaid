namespace Going.Plaid.Entity;

/// <summary>
/// <para>Enum representing the entity authenticating the user.</para>
/// </summary>
public enum ItemCreateAuthentication
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "UNKNOWN")]
	Unknown,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DATA_PARTNER")]
	DataPartner,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PLAID")]
	Plaid,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
