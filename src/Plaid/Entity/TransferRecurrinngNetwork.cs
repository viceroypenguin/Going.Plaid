namespace Going.Plaid.Entity;

/// <summary>
/// <para>Networks eligible for recurring transfers.</para>
/// </summary>
public enum TransferRecurrinngNetwork
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
	[EnumMember(Value = "rtp")]
	Rtp,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
