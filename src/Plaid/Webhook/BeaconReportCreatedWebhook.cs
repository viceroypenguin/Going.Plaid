namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when one of your Beacon Users is first reported to the Beacon network.</para>
/// </summary>
public record BeaconReportCreatedWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Beacon;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.ReportCreated;

	/// <summary>
	/// <para>The ID of the associated Beacon Report.</para>
	/// </summary>
	[JsonPropertyName("beacon_report_id")]
	public string BeaconReportId { get; init; } = default!;

}
