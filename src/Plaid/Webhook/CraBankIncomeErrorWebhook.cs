namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when a bank income report has failed to generate</para>
/// </summary>
public record CraBankIncomeErrorWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.CraIncome;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.Error;

	/// <summary>
	/// <para>The <c>user_id</c> corresponding to the user the webhook has fired for.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; init; } = default!;

}
