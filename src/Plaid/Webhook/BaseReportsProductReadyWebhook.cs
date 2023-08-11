namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when the Base Report has been generated and <c>/cra/base_report/get</c> is ready to be called.  If you attempt to retrieve a Base Report before this webhook has fired, you’ll receive a response with the HTTP status code 400 and a Plaid error code of <c>PRODUCT_NOT_READY</c>.</para>
/// </summary>
public record BaseReportsProductReadyWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.BaseReport;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.ProductReady;

	/// <summary>
	/// <para>The <c>user_id</c> corresponding to the User ID the webhook has fired for.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; init; } = default!;
}