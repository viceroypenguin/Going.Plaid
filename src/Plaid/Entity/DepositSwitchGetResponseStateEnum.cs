namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public enum DepositSwitchGetResponseStateEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "initialized")]
	Initialized,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "processing")]
	Processing,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "completed")]
	Completed,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "error")]
	Error,
}