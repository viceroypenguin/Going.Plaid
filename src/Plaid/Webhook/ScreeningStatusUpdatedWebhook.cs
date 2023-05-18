namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when an individual screening status has changed, which can occur manually via the dashboard or during ongoing monitoring.</para>
/// </summary>
public record ScreeningStatusUpdatedWebhook : WebhookBase
{
	/// <inheritdoc />
	public override WebhookType WebhookType => WebhookType.Screening;

	/// <inheritdoc />
	public override WebhookCode WebhookCode => WebhookCode.StatusUpdated;

	/// <summary>
	/// <para>The ID of the associated screening.</para>
	/// </summary>
	[JsonPropertyName("screening_id")]
	public string ScreeningId { get; init; } = default!;
}