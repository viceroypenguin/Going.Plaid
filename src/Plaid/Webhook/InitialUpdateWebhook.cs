namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when an Item's initial transaction pull is completed. Once this webhook has been fired, transaction data for the most recent 30 days can be fetched for the Item. This webhook will also be fired if account selections for the Item are updated, with <c>new_transactions</c> set to the number of net new transactions pulled after the account selection update.</para>
/// <para>This webhook is intended for use with <c>/transactions/get</c>; if you are using the newer <c>/transactions/sync</c> endpoint, this webhook will still be fired to maintain backwards compatibility, but it is recommended to listen for and respond to the <c>SYNC_UPDATES_AVAILABLE</c> webhook instead.</para>
/// </summary>
public record InitialUpdateWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Transactions;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.InitialUpdate;

	/// <summary>
	/// <para>The error code associated with the webhook.</para>
	/// </summary>
	[JsonPropertyName("error")]
	public string? Error { get; init; } = default!;

	/// <summary>
	/// <para>The number of new transactions available.</para>
	/// </summary>
	[JsonPropertyName("new_transactions")]
	public decimal NewTransactions { get; init; } = default!;

	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

}
