namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when the Asset Report has been generated and <c>/asset_report/get</c> is ready to be called.  If you attempt to retrieve an Asset Report before this webhook has fired, you’ll receive a response with the HTTP status code 400 and a Plaid error code of <c>PRODUCT_NOT_READY</c>.</para>
/// </summary>
public record AssetsProductReadyWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Assets;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.ProductReady;

	/// <summary>
	/// <para>The <c>asset_report_id</c> corresponding to the Asset Report the webhook has fired for.</para>
	/// </summary>
	[JsonPropertyName("asset_report_id")]
	public string AssetReportId { get; init; } = default!;

	/// <summary>
	/// <para>The report type, indicating whether the Asset Report is a <c>full</c> or <c>fast</c> report.</para>
	/// </summary>
	[JsonPropertyName("report_type")]
	public string? ReportType { get; init; } = default!;
}