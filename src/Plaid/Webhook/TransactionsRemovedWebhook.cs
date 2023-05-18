namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when transaction(s) for an Item are deleted. The deleted transaction IDs are included in the webhook payload. Plaid will typically check for deleted transaction data several times a day.</para>
/// <para>This webhook is intended for use with <c>/transactions/get</c>; if you are using the newer <c>/transactions/sync</c> endpoint, this webhook will still be fired to maintain backwards compatibility, but it is recommended to listen for and respond to the <c>SYNC_UPDATES_AVAILABLE</c> webhook instead.</para>
/// </summary>
public record TransactionsRemovedWebhook : WebhookBase
{
	/// <inheritdoc />
	public override WebhookType WebhookType => WebhookType.Transactions;

	/// <inheritdoc />
	public override WebhookCode WebhookCode => WebhookCode.TransactionsRemoved;

	/// <summary>
	/// <para>We use standard HTTP response codes for success and failure notifications, and our errors are further classified by <c>error_type</c>. In general, 200 HTTP codes correspond to success, 40X codes are for developer- or user-related failures, and 50X codes are for Plaid-related issues. An Item with a non-<c>null</c> error object will only be part of an API response when calling <c>/item/get</c> to view Item status. Otherwise, error fields will be <c>null</c> if no error has occurred; if an error has occurred, an error code will be returned instead.</para>
	/// </summary>
	[JsonPropertyName("error")]
	public Entity.PlaidError? Error { get; init; } = default!;

	/// <summary>
	/// <para>An array of <c>transaction_ids</c> corresponding to the removed transactions</para>
	/// </summary>
	[JsonPropertyName("removed_transactions")]
	public IReadOnlyList<string> RemovedTransactions { get; init; } = default!;

	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;
}