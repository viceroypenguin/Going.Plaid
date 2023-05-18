namespace Going.Plaid.Entity;

/// <summary>
/// <para>The possible types of identity data that may have changed.</para>
/// </summary>
public enum IdentityUpdateTypes
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "PHONES")]
	Phones,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ADDRESSES")]
	Addresses,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "EMAILS")]
	Emails,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "NAMES")]
	Names,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}