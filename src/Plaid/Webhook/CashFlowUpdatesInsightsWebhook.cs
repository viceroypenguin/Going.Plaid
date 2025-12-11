namespace Going.Plaid.Webhook;

/// <summary>
/// <para>For each user's Item enabled for Cash Flow Updates, this webhook will fire between one and four times a day with information on the status of the update. This webhook will not fire immediately upon enrollment in Cash Flow Updates. Upon receiving the webhook, call <c>/cra/monitoring_insights/get</c> to retrieve the updated insights. At approximately the same time as the <c>INSIGHTS_UPDATED</c> webhook, any event-driven <c>CASH_FLOW_UPDATES</c> webhooks (e.g. <c>LOW_BALANCE_DETECTED</c>, <c>LARGE_DEPOSIT_DETECTED</c>) that were triggered by the update will also fire. This webhook has been replaced by the <c>CASH_FLOW_INSIGHTS_UPDATED</c> webhook for all customers who began using Plaid Check on or after December 10, 2025.</para>
/// </summary>
public record CashFlowUpdatesInsightsWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.CashFlowUpdates;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.InsightsUpdated;

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
