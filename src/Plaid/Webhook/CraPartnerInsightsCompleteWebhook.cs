namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when a partner insights report has finished generating or failed to generate.</para>
/// </summary>
public record CraPartnerInsightsCompleteWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.CraInsights;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.PartnerInsightsComplete;

	/// <summary>
	/// <para>The <c>user_id</c> corresponding to the user the webhook has fired for.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; init; } = default!;

	/// <summary>
	/// <para>The result of the partner insights report generation</para>
	/// </summary>
	[JsonPropertyName("result")]
	public Entity.CraPartnerInsightsCompleteResult Result { get; init; } = default!;

}
