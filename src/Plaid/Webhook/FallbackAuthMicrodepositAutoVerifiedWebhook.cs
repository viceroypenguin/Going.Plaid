namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fires when an account is automatically verified using micro-deposits</para>
/// </summary>
public record FallbackAuthMicrodepositAutoVerifiedWebhook : WebhookBase
{
	/// <inheritdoc />
	public override WebhookType WebhookType => WebhookType.Auth;

	/// <inheritdoc />
	public override WebhookCode WebhookCode => WebhookCode.AutomaticallyVerified;

	/// <summary>
	/// <para>The error code associated with the webhook.</para>
	/// </summary>
	[JsonPropertyName("error")]
	public string? Error { get; init; } = default!;

	/// <summary>
	/// <para>The external account ID associated with the micro-deposit</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;

	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;
}