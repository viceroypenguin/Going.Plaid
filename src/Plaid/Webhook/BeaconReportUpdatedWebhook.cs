namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when one of your existing Beacon Reports has been modified or removed from the Beacon Network.</para>
/// </summary>
public record BeaconReportUpdatedWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Beacon;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.ReportUpdated;

	/// <summary>
	/// <para>The ID of the associated Beacon Report.</para>
	/// </summary>
	[JsonPropertyName("beacon_report_id")]
	public string BeaconReportId { get; init; } = default!;

}
