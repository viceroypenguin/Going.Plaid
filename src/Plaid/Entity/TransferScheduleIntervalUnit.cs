namespace Going.Plaid.Entity;

/// <summary>
/// <para>The unit of the recurring interval.</para>
/// </summary>
public enum TransferScheduleIntervalUnit
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "week")]
	Week,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "month")]
	Month,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
