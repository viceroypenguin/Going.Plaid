namespace Going.Plaid.Entity;

/// <summary>
/// <para>The network or rails used for the transfer. Valid options are <c>ach</c> or <c>same-day-ach</c>.</para>
/// </summary>
public enum TransferNetwork
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
}