namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when an Item was not verified via automated micro-deposits after seven days since the automated micro-deposit was made.</para>
/// </summary>
public record VerificationExpiredWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Auth;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.VerificationExpired;

	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// <para>The <c>account_id</c> of the account associated with the webhook</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;
}