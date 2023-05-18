namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when an Item is verified via automated micro-deposits. We recommend communicating to your users when this event is received to notify them that their account is verified and ready for use.</para>
/// </summary>
public record AutomaticallyVerifiedWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Auth;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.AutomaticallyVerified;

	/// <summary>
	/// <para>The <c>account_id</c> of the account associated with the webhook</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;
}