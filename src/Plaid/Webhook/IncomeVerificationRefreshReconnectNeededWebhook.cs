namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when the attempt to refresh Payroll Income data for a user via <c>/credit/payroll_income/refresh</c> failed because the user must re-connect their payroll account.</para>
/// </summary>
public record IncomeVerificationRefreshReconnectNeededWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Income;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.IncomeVerificationRefreshReconnectNeeded;

	/// <summary>
	/// <para>The <c>user_id</c> corresponding to the user the webhook has fired for.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; init; } = default!;
}