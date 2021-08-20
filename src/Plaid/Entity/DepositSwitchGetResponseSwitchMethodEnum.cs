namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public enum DepositSwitchGetResponseSwitchMethodEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "instant")]
	Instant,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "mail")]
	Mail,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "pdf")]
	Pdf,
}