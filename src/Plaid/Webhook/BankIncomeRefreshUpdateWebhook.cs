namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when a change to the user's income is detected. You should call <c>/credit/bank_income/refresh</c> to get updated income data for the user</para>
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