namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when a Beacon User created within your organization matches one of your existing users.</para>
/// </summary>
public record BeaconDuplicateDetectedWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Beacon;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.DuplicateDetected;

	/// <summary>
	/// <para>The ID of the associated Beacon Duplicate.</para>
	/// </summary>
	[JsonPropertyName("beacon_duplicate_id")]
	public string BeaconDuplicateId { get; init; } = default!;

}
