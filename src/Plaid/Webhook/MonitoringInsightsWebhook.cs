namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Every 14 days, the webhook will be fired per item enabled for Monitoring Insights.</para>
/// </summary>
public record MonitoringInsightsWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.CraMonitoring;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.InsightsUpdated;

	/// <summary>
	/// <para>Enum for the status of the insights</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.MonitoringInsightsStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>The reason for why insights may not be <c>AVAILABLE</c></para>
	/// </summary>
	[JsonPropertyName("reason")]
	public string? Reason { get; init; } = default!;

	/// <summary>
	/// <para>The <c>user_id</c> that the report is associated with</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; init; } = default!;

}
