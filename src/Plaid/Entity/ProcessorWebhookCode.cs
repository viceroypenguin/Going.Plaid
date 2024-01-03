namespace Going.Plaid.Entity;

/// <summary>
/// <para>A list of supported Webhook Payload codes.</para>
/// </summary>
public enum ProcessorWebhookCode
{
	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "TRANSACTIONS_REMOVED")]
	TransactionsRemoved,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "DEFAULT_UPDATE")]
	DefaultUpdate,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "SYNC_UPDATES_AVAILABLE")]
	SyncUpdatesAvailable,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "RECURRING_TRANSACTIONS_UPDATE")]
	RecurringTransactionsUpdate,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "HISTORICAL_UPDATE")]
	HistoricalUpdate,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "INITIAL_UPDATE")]
	InitialUpdate,

	/// <summary>
	/// <para>Catch-all for unknown values returned by Plaid. If you encounter this, please check if there is a later version of the Going.Plaid library.</para>
	/// </summary>
	[EnumMember(Value = "undefined")]
	Undefined,

}
