namespace Going.Plaid.Entity;

/// <summary>
/// <para>The possible types of identity data that may have changed.</para>
/// </summary>
public enum IdentityUpdateTypes
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "addresses")]
	Addresses,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "emails")]
	Emails,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "names")]
	Names,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "phone_numbers")]
	PhoneNumbers,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
