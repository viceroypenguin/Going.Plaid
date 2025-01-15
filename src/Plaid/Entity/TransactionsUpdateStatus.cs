namespace Going.Plaid.Entity;

/// <summary>
/// <para>A description of the update status for transaction pulls of an Item. This field contains the same information provided by transactions webhooks, and may be helpful for webhook troubleshooting or when recovering from missed webhooks.</para>
/// </summary>
public enum TransactionsUpdateStatus
{
	/// <summary>
	/// <para>Unable to fetch transactions update status for Item.</para>
	/// </summary>
	[EnumMember(Value = "TRANSACTIONS_UPDATE_STATUS_UNKNOWN")]
	TransactionsUpdateStatusUnknown,

	/// <summary>
	/// <para>The Item is pending transaction pull.</para>
	/// </summary>
	[EnumMember(Value = "NOT_READY")]
	NotReady,

	/// <summary>
	/// <para>Initial pull for the Item is complete, historical pull is pending.</para>
	/// </summary>
	[EnumMember(Value = "INITIAL_UPDATE_COMPLETE")]
	InitialUpdateComplete,

	/// <summary>
	/// <para>Both initial and historical pull for Item are complete.</para>
	/// </summary>
	[EnumMember(Value = "HISTORICAL_UPDATE_COMPLETE")]
	HistoricalUpdateComplete,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
