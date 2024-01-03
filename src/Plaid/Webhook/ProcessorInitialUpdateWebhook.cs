namespace Going.Plaid.Webhook;

/// <summary>
/// <para>This webhook is only sent to <a href="https://plaid.com/docs/auth/partnerships/">Plaid processor partners</a>.</para>
/// <para>Fired when an Item's initial transaction pull is completed. Once this webhook has been fired, transaction data for the most recent 30 days can be fetched for the Item. If <a href="https://plaid.com/docs/link/customization/#account-select">Account Select v2</a> is enabled, this webhook will also be fired if account selections for the Item are updated, with <c>new_transactions</c> set to the number of net new transactions pulled after the account selection update.</para>
/// <para>This webhook is intended for use with <c>/processor/transactions/get</c>; if you are using the newer <c>/processor/transactions/sync</c> endpoint, this webhook will still be fired to maintain backwards compatibility, but it is recommended to listen for and respond to the <c>SYNC_UPDATES_AVAILABLE</c> webhook instead.</para>
/// </summary>
public record ProcessorInitialUpdateWebhook : ProcessorWebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override ProcessorWebhookType WebhookType => ProcessorWebhookType.Transactions;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override ProcessorWebhookCode WebhookCode => ProcessorWebhookCode.InitialUpdate;

	/// <summary>
	/// <para>The error code associated with the webhook.</para>
	/// </summary>
	[JsonPropertyName("error")]
	public string? Error { get; init; } = default!;

	/// <summary>
	/// <para>The number of new, unfetched transactions available.</para>
	/// </summary>
	[JsonPropertyName("new_transactions")]
	public decimal NewTransactions { get; init; } = default!;

	/// <summary>
	/// <para>The ID of the account.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

}
