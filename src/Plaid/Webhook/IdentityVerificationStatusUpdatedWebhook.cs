namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when the status of an identity verification has been updated, which can be triggered via the dashboard or the API.</para>
/// </summary>
public record IdentityVerificationStatusUpdatedWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.IdentityVerification;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.StatusUpdated;

	/// <summary>
	/// <para>The ID of the associated Identity Verification attempt.</para>
	/// </summary>
	[JsonPropertyName("identity_verification_id")]
	public string IdentityVerificationId { get; init; } = default!;

}
