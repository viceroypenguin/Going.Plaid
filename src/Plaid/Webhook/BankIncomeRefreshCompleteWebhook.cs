namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when a refreshed bank income report has finished generating or failed to generate, triggered by calling <c>/credit/bank_income/refresh</c>. To get this webhook, subscribe via the <a href="https://dashboard.plaid.com/developers/webhooks">Dashboard</a>.</para>
/// </summary>
public record BankIncomeRefreshCompleteWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Income;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.BankIncomeRefreshComplete;

	/// <summary>
	/// <para>The <c>user_id</c> corresponding to the user the webhook has fired for.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; init; } = default!;

	/// <summary>
	/// <para>The result of the bank income refresh report generation</para>
	/// </summary>
	[JsonPropertyName("result")]
	public Entity.BankIncomeRefreshCompleteResult Result { get; init; } = default!;

}
