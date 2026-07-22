namespace Going.Plaid.Entity;

/// <summary>
/// 
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

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "rtp")]
	Rtp,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "wire")]
	Wire,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "rfp")]
	Rfp,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
