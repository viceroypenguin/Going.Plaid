namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when the status of an onboarding originator has been updated. Call <c>/transfer/originator/get</c> to check the latest status</para>
/// </summary>
public record TransferPlatformOnboardingUpdateWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Transfer;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.PlatformOnboardingUpdate;

	/// <summary>
	/// <para>The client ID of the originator</para>
	/// </summary>
	[JsonPropertyName("originator_client_id")]
	public string OriginatorClientId { get; init; } = default!;

}
