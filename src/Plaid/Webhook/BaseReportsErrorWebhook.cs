namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when Base Report generation has failed. The resulting <c>error</c> will have an <c>error_type</c> of <c>BASE_REPORT_ERROR</c>.</para>
/// </summary>
public record BaseReportsErrorWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.BaseReport;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.Error;

	/// <summary>
	/// <para>We use standard HTTP response codes for success and failure notifications, and our errors are further classified by <c>error_type</c>. In general, 200 HTTP codes correspond to success, 40X codes are for developer- or user-related failures, and 50X codes are for Plaid-related issues. An Item with a non-<c>null</c> error object will only be part of an API response when calling <c>/item/get</c> to view Item status. Otherwise, error fields will be <c>null</c> if no error has occurred; if an error has occurred, an error code will be returned instead.</para>
	/// </summary>
	[JsonPropertyName("error")]
	public Entity.PlaidError? Error { get; init; } = default!;

	/// <summary>
	/// <para>The ID associated with the Asset Report.</para>
	/// </summary>
	[JsonPropertyName("asset_report_id")]
	public string? AssetReportId { get; init; } = default!;
}