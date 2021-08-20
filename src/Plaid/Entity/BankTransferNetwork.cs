namespace Going.Plaid.Entity;

/// <summary>
/// <para>The network or rails used for the transfer. Valid options are <c>ach</c>, <c>same-day-ach</c>, or <c>wire</c>.</para>
/// </summary>
public enum BankTransferNetwork
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "ach")]
	Ach,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "same-day-ach")]
	SameDayAch,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "wire")]
	Wire,
}