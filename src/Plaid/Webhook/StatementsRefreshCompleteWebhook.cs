namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when refreshed statements extraction is completed or failed to be completed. Triggered by calling <c>/statements/refresh</c>.</para>
/// </summary>
public record StatementsRefreshCompleteWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Statements;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.StatementsRefreshComplete;

	/// <summary>
	/// <para>The Plaid Item ID. The <c>item_id</c> is always unique; linking the same account at the same institution twice will result in two Items with different <c>item_id</c> values. Like all Plaid identifiers, the <c>item_id</c> is case-sensitive.</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// <para>The result of the statement refresh extraction</para>
	/// </summary>
	[JsonPropertyName("result")]
	public Entity.StatementsRefreshCompleteResult Result { get; init; } = default!;

}
