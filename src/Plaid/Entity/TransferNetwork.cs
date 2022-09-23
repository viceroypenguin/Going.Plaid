namespace Going.Plaid.Entity;

/// <summary>
/// <para>The network or rails used for the transfer. Valid options are <c>ach</c> or <c>same-day-ach</c>. The cutoff for same-day transfers is 9:30 AM Pacific Time and the cutoff for next-day transfers is 5:30 PM Pacific Time. It is recommended to submit a transfer at least 15 minutes before the cutoff time in order to ensure that it will be processed before the cutoff. Any transfer that is indicated as <c>same-day-ach</c> and that misses the same-day cutoff, but is submitted in time for the next-day cutoff, will be sent over next-day rails and will not incur same-day charges. Note that both legs of the transfer will be downgraded if applicable.</para>
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
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,
}