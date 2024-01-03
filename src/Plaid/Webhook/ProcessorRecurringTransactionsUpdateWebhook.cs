namespace Going.Plaid.Webhook;

/// <summary>
/// <para>This webhook is only sent to <a href="https://plaid.com/docs/auth/partnerships/">Plaid processor partners</a>.</para>
/// <para>Fired when recurring transactions data is updated. This includes when a new recurring stream is detected or when a new transaction is added to an existing recurring stream. The <c>RECURRING_TRANSACTIONS_UPDATE</c> webhook will also fire when one or more attributes of the recurring stream changes, which is usually a result of the addition, update, or removal of transactions to the stream.</para>
/// <para>After receipt of this webhook, the updated data can be fetched from <c>/processor/transactions/recurring/get</c>.</para>
/// </summary>
public record ProcessorRecurringTransactionsUpdateWebhook : ProcessorWebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override ProcessorWebhookType WebhookType => ProcessorWebhookType.Transactions;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override ProcessorWebhookCode WebhookCode => ProcessorWebhookCode.RecurringTransactionsUpdate;

	/// <summary>
	/// <para>The ID of the account.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

}
