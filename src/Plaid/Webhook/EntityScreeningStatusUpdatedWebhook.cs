namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when an entity screening status has changed, which can occur manually via the dashboard or during ongoing monitoring.</para>
/// </summary>
public record EntityScreeningStatusUpdatedWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.EntityScreening;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.StatusUpdated;

	/// <summary>
	/// <para>The ID of the associated entity screening.</para>
	/// </summary>
	[JsonPropertyName("entity_screening_id")]
	public string EntityScreeningId { get; init; } = default!;

}
