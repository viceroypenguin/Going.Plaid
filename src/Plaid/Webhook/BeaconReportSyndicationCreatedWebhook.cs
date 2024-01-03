namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when a report created on the Beacon Network matches with one of your Beacon Users.</para>
/// </summary>
public record BeaconReportSyndicationCreatedWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Beacon;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.ReportSyndicationCreated;

	/// <summary>
	/// <para>The ID of the associated Beacon Report Syndication.</para>
	/// </summary>
	[JsonPropertyName("beacon_report_syndication_id")]
	public string BeaconReportSyndicationId { get; init; } = default!;

}
