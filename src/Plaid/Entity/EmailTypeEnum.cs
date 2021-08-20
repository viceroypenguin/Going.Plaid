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
}