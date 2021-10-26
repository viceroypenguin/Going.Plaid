namespace Going.Plaid.Entity;

/// <summary>
/// <para>The type of email account as described by the financial institution.</para>
/// </summary>
public enum EmailTypeEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "primary")]
	Primary,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "secondary")]
	Secondary,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "other")]
	Other,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}