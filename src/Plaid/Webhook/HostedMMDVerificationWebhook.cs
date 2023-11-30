namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Contains the state of a hosted same-day microdeposits verification session.</para>
/// </summary>
public record HostedMMDVerificationWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Auth;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.HostedVerification;

	/// <summary>
	/// <para>The final status of the same-day microdeposits verification. Will always be "MANUALLY_VERIFIED" or "VERIFICATION_FAILED".</para>
	/// </summary>
	[JsonPropertyName("status")]
	public string Status { get; init; } = default!;

	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

	/// <summary>
	/// <para>The external account ID of the affected account</para>
	/// </summary>
	[JsonPropertyName("account_id")]
	public string AccountId { get; init; } = default!;
}