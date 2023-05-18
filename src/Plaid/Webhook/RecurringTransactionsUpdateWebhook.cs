namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when recurring transactions data is updated. This includes when a new recurring stream is detected or when a new transaction is added to an existing recurring stream. The <c>RECURRING_TRANSACTIONS_UPDATE</c> webhook will also fire when one or more attributes of the recurring stream changes, which is usually a result of the addition, update, or removal of transactions to the stream.</para>
/// <para>After receipt of this webhook, the updated data can be fetched from <c>/transactions/recurring/get</c>.</para>
/// </summary>
public record RecurringTransactionsUpdateWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Transactions;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.RecurringTransactionsUpdate;

	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// <para>A list of <c>account_ids</c> for accounts that have new or updated recurring transactions data.</para>
	/// </summary>
	[JsonPropertyName("account_ids")]
	public IReadOnlyList<string> AccountIds { get; init; } = default!;
}