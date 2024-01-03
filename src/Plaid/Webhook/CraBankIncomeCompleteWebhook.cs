namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when a bank income report has finished generating or failed to generate, triggered by calling <c>/cra/bank_income/get</c>.</para>
/// </summary>
public record CraBankIncomeCompleteWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.CraIncome;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.BankIncomeComplete;

	/// <summary>
	/// <para>The <c>user_id</c> corresponding to the user the webhook has fired for.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; init; } = default!;

	/// <summary>
	/// <para>The result of the bank income report generation</para>
	/// </summary>
	[JsonPropertyName("result")]
	public Entity.CraBankIncomeCompleteResult Result { get; init; } = default!;

}
