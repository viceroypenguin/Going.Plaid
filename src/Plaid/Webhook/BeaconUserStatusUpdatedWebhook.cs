namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when a Beacon User status has changed, which can occur manually via the dashboard or when information is reported to the Beacon network.</para>
/// </summary>
public record BeaconUserStatusUpdatedWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Beacon;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.UserStatusUpdated;

	/// <summary>
	/// <para>The ID of the associated Beacon user.</para>
	/// </summary>
	[JsonPropertyName("beacon_user_id")]
	public string BeaconUserId { get; init; } = default!;
}