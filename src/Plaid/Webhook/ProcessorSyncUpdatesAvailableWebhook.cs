namespace Going.Plaid.Webhook;

/// <summary>
/// <para>This webhook is only sent to <a href="https://plaid.com/docs/auth/partnerships/">Plaid processor partners</a>.</para>
/// <para>Fired when an Item's transactions change. This can be due to any event resulting in new changes, such as an initial 30-day transactions fetch upon the initialization of an Item with transactions, the backfill of historical transactions that occurs shortly after, or when changes are populated from a regularly-scheduled transactions update job. It is recommended to listen for the <c>SYNC_UPDATES_AVAILABLE</c> webhook when using the <c>/processor/transactions/sync</c> endpoint. Note that when using <c>/processor/transactions/sync</c> the older webhooks <c>INITIAL_UPDATE</c>, <c>HISTORICAL_UPDATE</c>, <c>DEFAULT_UPDATE</c>, and <c>TRANSACTIONS_REMOVED</c>, which are intended for use with <c>/processor/transactions/get</c>, will also continue to be sent in order to maintain backwards compatibility. It is not necessary to listen for and respond to those webhooks when using <c>/processor/transactions/sync</c>.</para>
/// <para>After receipt of this webhook, the new changes can be fetched for the Item from <c>/processor/transactions/sync</c>.</para>
/// <para>Note that to receive this webhook for an Item, <c>/processor/transactions/sync</c> must have been called at least once on that Item. This means that, unlike the <c>INITIAL_UPDATE</c> and <c>HISTORICAL_UPDATE</c> webhooks, it will not fire immediately upon Item creation. If <c>/transactions/sync</c> is called on an Item that was *not* initialized with Transactions, the webhook will fire twice: once the first 30 days of transactions data has been fetched, and a second time when all available historical transactions data has been fetched.</para>
/// <para>This webhook will typically not fire in the Sandbox environment, due to the lack of dynamic transactions data. To test this webhook in Sandbox, call <c>/sandbox/item/fire_webhook</c>.</para>
/// </summary>
public record ProcessorSyncUpdatesAvailableWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Transactions;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.SyncUpdatesAvailable;

	/// <summary>
	/// <para>The ID of the account.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>Indicates if initial pull information is available.</para>
	/// </summary>
	[JsonPropertyName("initial_update_complete")]
	public bool InitialUpdateComplete { get; init; } = default!;

	/// <summary>
	/// <para>Indicates if historical pull information is available.</para>
	/// </summary>
	[JsonPropertyName("historical_update_complete")]
	public bool HistoricalUpdateComplete { get; init; } = default!;

}
