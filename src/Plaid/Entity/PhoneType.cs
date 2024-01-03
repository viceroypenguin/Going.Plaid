namespace Going.Plaid.Entity;

/// <summary>
/// <para>An enum indicating whether a phone number is a phone line or a fax line.</para>
/// </summary>
public enum PhoneType
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "phone")]
	Phone,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "fax")]
	Fax,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
