namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when an Item's historical transaction pull is completed and Plaid has prepared as much historical transaction data as possible for the Item. Once this webhook has been fired, transaction data beyond the most recent 30 days can be fetched for the Item. If <a href="https://plaid.com/docs/link/customization/#account-select">Account Select v2</a> is enabled, this webhook will also be fired if account selections for the Item are updated, with <c>new_transactions</c> set to the number of net new transactions pulled after the account selection update.</para>
/// <para>This webhook is intended for use with <c>/transactions/get</c>; if you are using the newer <c>/transactions/sync</c> endpoint, this webhook will still be fired to maintain backwards compatibility, but it is recommended to listen for and respond to the <c>SYNC_UPDATES_AVAILABLE</c> webhook instead.</para>
/// </summary>
public record HistoricalUpdateWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Transactions;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.HistoricalUpdate;

	/// <summary>
	/// <para>We use standard HTTP response codes for success and failure notifications, and our errors are further classified by <c>error_type</c>. In general, 200 HTTP codes correspond to success, 40X codes are for developer- or user-related failures, and 50X codes are for Plaid-related issues. An Item with a non-<c>null</c> error object will only be part of an API response when calling <c>/item/get</c> to view Item status. Otherwise, error fields will be <c>null</c> if no error has occurred; if an error has occurred, an error code will be returned instead.</para>
	/// </summary>
	[JsonPropertyName("error")]
	public Entity.PlaidError? Error { get; init; } = default!;

	/// <summary>
	/// <para>The number of new, unfetched transactions available</para>
	/// </summary>
	[JsonPropertyName("new_transactions")]
	public decimal NewTransactions { get; init; } = default!;

	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

}
