namespace Going.Plaid.Webhook;

/// <summary>
/// <para>For each user enabled for Cash Flow Updates, this webhook will fire when an update detects a low balance (below $100). Upon receiving the webhook, call <c>/cra/monitoring_insights/get</c> to retrieve the updated insights.</para>
/// </summary>
public record CashFlowUpdatesLowBalanceWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.CashFlowUpdates;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.LowBalanceDetected;

	/// <summary>
	/// <para>Enum for the status of the insights</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.MonitoringInsightsStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>The <c>user_id</c> that the report is associated with</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; init; } = default!;

}
