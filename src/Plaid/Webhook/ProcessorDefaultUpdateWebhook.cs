namespace Going.Plaid.Webhook;

/// <summary>
/// <para>This webhook is only sent to <a href="https://plaid.com/docs/auth/partnerships/">Plaid processor partners</a>.</para>
/// <para>Fired when new transaction data is available for an Item. Plaid will typically check for new transaction data several times a day.</para>
/// <para>This webhook is intended for use with <c>/processor/transactions/get</c>; if you are using the newer <c>/processor/transactions/sync</c> endpoint, this webhook will still be fired to maintain backwards compatibility, but it is recommended to listen for and respond to the <c>SYNC_UPDATES_AVAILABLE</c> webhook instead.</para>
/// </summary>
public record ProcessorDefaultUpdateWebhook : ProcessorWebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override ProcessorWebhookType WebhookType => ProcessorWebhookType.Transactions;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override ProcessorWebhookCode WebhookCode => ProcessorWebhookCode.DefaultUpdate;

	/// <summary>
	/// <para>We use standard HTTP response codes for success and failure notifications, and our errors are further classified by <c>error_type</c>. In general, 200 HTTP codes correspond to success, 40X codes are for developer- or user-related failures, and 50X codes are for Plaid-related issues. An Item with a non-<c>null</c> error object will only be part of an API response when calling <c>/item/get</c> to view Item status. Otherwise, error fields will be <c>null</c> if no error has occurred; if an error has occurred, an error code will be returned instead.</para>
	/// </summary>
	[JsonPropertyName("error")]
	public Entity.PlaidError? Error { get; init; } = default!;

	/// <summary>
	/// <para>The number of new transactions detected since the last time this webhook was fired.</para>
	/// </summary>
	[JsonPropertyName("new_transactions")]
	public decimal NewTransactions { get; init; } = default!;

	/// <summary>
	/// <para>The ID of the account.</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

}
