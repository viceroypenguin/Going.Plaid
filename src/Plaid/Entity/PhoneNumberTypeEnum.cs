namespace Going.Plaid.Entity;

/// <summary>
/// <para>The type of phone number.</para>
/// </summary>
public enum PhoneNumberTypeEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "home")]
	Home,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "work")]
	Work,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "office")]
	Office,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "mobile")]
	Mobile,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "mobile1")]
	Mobile1,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "other")]
	Other,
}