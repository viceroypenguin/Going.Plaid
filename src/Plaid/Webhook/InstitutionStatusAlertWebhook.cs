namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when institution status meets the conditions configured in the developer dashboard.</para>
/// </summary>
public record InstitutionStatusAlertWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.DashboardConfiguredAlert;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.InstitutionStatusAlertTriggered;

	/// <summary>
	/// <para>The ID of the associated institution.</para>
	/// </summary>
	[JsonPropertyName("institution_id")]
	public string InstitutionId { get; init; } = default!;

	/// <summary>
	/// <para>The global success rate of the institution, calculated based on item add health.</para>
	/// </summary>
	[JsonPropertyName("institution_overall_success_rate")]
	public decimal InstitutionOverallSuccessRate { get; init; } = default!;

}
