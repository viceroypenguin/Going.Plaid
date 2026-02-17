namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when an Item is expected to be disconnected. The webhook will currently be fired 7 days before the existing Item is scheduled for disconnection. This can be resolved by having the user go through Link’s <a href="http://plaid.com/docs/link/update-mode">update mode</a>. Currently, this webhook is fired only for US or Canadian institutions; in the UK or EU, you should continue to listed for the <a href="https://plaid.com/docs/api/items/#pending_expiration"><c>PENDING_EXPIRATION</c></a> webhook instead.</para>
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
	/// <para>The Plaid <c>user_id</c> of the User associated with this webhook, warning, or error.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; init; } = default!;

	/// <summary>
	/// <para>Reason why the item is about to be disconnected.</para>
	/// </summary>
	[JsonPropertyName("reason")]
	public Entity.PendingDisconnectWebhookReason Reason { get; init; } = default!;

}
