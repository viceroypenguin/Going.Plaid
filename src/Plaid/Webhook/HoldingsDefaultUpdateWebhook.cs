namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when new or updated holdings have been detected on an investment account. The webhook typically fires in response to any newly added holdings or price changes to existing holdings, most commonly after market close.</para>
/// </summary>
public record HoldingsDefaultUpdateWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Holdings;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.DefaultUpdate;

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
	/// <para>The number of new holdings reported since the last time this webhook was fired.</para>
	/// </summary>
	[JsonPropertyName("new_holdings")]
	public decimal NewHoldings { get; init; } = default!;

	/// <summary>
	/// <para>The number of updated holdings reported since the last time this webhook was fired.</para>
	/// </summary>
	[JsonPropertyName("updated_holdings")]
	public decimal UpdatedHoldings { get; init; } = default!;

}
