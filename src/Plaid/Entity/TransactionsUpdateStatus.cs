namespace Going.Plaid.Entity;

/// <summary>
/// <para>A description of the update status for transaction pulls of an item.</para>
/// </summary>
public enum TransactionsUpdateStatus
{
	/// <summary>
	/// <para>Error, unable to fetch transactions update state for item.</para>
	/// </summary>
	[EnumMember(Value = "TRANSACTIONS_UPDATE_STATE_UNKNOWN")]
	TransactionsUpdateStateUnknown,

	/// <summary>
	/// <para>The item is pending transaction pull.</para>
	/// </summary>
	[EnumMember(Value = "NOT_READY")]
	NotReady,

	/// <summary>
	/// <para>Initial pull for the item is complete, pending Historical pull.</para>
	/// </summary>
	[EnumMember(Value = "INITIAL_UPDATE_COMPLETE")]
	InitialUpdateComplete,

	/// <summary>
	/// <para>Both Initial and Historical pull for item is complete.</para>
	/// </summary>
	[EnumMember(Value = "HISTORICAL_UPDATE_COMPLETE")]
	HistoricalUpdateComplete,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
