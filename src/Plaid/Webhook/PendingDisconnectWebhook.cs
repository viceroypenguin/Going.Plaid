namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when an Item is expected to be disconnected. This can be resolved by having the user go through Link’s <a href="http://plaid.com/docs/link/update-mode">update mode</a>.</para>
/// </summary>
public record PendingDisconnectWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Item;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.PendingDisconnect;

	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// <para>Reason why the item is about to be disconnected.</para>
	/// </summary>
	[JsonPropertyName("reason")]
	public Entity.PendingDisconnectWebhookReason Reason { get; init; } = default!;

}
