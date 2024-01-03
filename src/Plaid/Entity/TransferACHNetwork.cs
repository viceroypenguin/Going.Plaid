namespace Going.Plaid.Entity;

/// <summary>
/// 
/// </summary>
public enum TransferACHNetwork
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
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
