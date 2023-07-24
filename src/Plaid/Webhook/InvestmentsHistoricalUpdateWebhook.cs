namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired after an asynchronous extraction on an investments account.</para>
/// </summary>
public record InvestmentsHistoricalUpdateWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.InvestmentsTransactions;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.HistoricalUpdate;

	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// <para>We use standard HTTP response codes for success and failure notifications, and our errors are further classified by <c>error_type</c>. In general, 200 HTTP codes correspond to success, 40X codes are for developer- or user-related failures, and 50X codes are for Plaid-related issues. An Item with a non-<c>null</c> error object will only be part of an API response when calling <c>/item/get</c> to view Item status. Otherwise, error fields will be <c>null</c> if no error has occurred; if an error has occurred, an error code will be returned instead.</para>
	/// </summary>
	[JsonPropertyName("error")]
	public Entity.PlaidError? Error { get; init; } = default!;

	/// <summary>
	/// <para>The number of new transactions reported since the last time this webhook was fired.</para>
	/// </summary>
	[JsonPropertyName("new_investments_transactions")]
	public decimal NewInvestmentsTransactions { get; init; } = default!;

	/// <summary>
	/// <para>The number of canceled transactions reported since the last time this webhook was fired.</para>
	/// </summary>
	[JsonPropertyName("canceled_investments_transactions")]
	public decimal CanceledInvestmentsTransactions { get; init; } = default!;
}