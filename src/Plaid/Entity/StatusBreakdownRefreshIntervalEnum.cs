namespace Going.Plaid.Entity;

/// <summary>
/// <para>How frequently data for subscription products like Investments, Transactions, and Liabilities, is being refreshed, relative to the institution's normal scheduling. The <c>refresh_interval</c> may be <c>DELAYED</c> or <c>STOPPED</c> even when the success rate is high.</para>
/// </summary>
public enum StatusBreakdownRefreshIntervalEnum
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "NORMAL")]
	Normal,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DELAYED")]
	Delayed,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "STOPPED")]
	Stopped,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
