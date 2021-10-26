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

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "unknown")]
	Unknown,
}