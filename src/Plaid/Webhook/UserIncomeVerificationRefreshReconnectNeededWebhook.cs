namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when the attempt to refresh Payroll Income data for a user via <c>/credit/payroll_income/refresh</c> failed because the user must re-connect their payroll account.</para>
/// </summary>
public record UserIncomeVerificationRefreshReconnectNeededWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Income;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.UserIncomeVerificationRefreshReconnectNeeded;

	/// <summary>
	/// <para>A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">New User APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; init; } = default!;

}
