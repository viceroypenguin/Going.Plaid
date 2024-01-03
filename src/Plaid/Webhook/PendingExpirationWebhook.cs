namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when an Item’s access consent is expiring in 7 days. Some Items have explicit expiration times and we try to relay this when possible to reduce service disruption. This can be resolved by having the user go through Link’s update mode.</para>
/// </summary>
public record PendingExpirationWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Item;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.PendingExpiration;

	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// <para>The date and time at which the Item's access consent will expire, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format</para>
	/// </summary>
	[JsonPropertyName("consent_expiration_time")]
	public DateTimeOffset ConsentExpirationTime { get; init; } = default!;

}
