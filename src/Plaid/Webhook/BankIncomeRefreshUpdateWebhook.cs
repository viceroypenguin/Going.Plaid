namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when a change to the user's income is detected. The <c>/credit/bank_income/refresh</c> endpoint that previously served this refresh is deprecated; to get updated income data, send the user through Link's update mode so they can confirm their income sources, or migrate to CRA Income Insights and call <c>/cra/check_report/create</c> for a backend refresh. To receive this webhook, subscribe in the <a href="https://dashboard.plaid.com/developers/webhooks">Dashboard</a>.</para>
/// </summary>
public record BankIncomeRefreshUpdateWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Income;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.BankIncomeRefreshUpdate;

	/// <summary>
	/// <para>The <c>user_id</c> corresponding to the user the webhook has fired for.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; init; } = default!;

}
