namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when a Check Report has failed to generate</para>
/// </summary>
public record CraUserCheckReportFailedWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.CheckReport;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.UserCheckReportFailed;

	/// <summary>
	/// <para>The <c>user_id</c> corresponding to the user the webhook has fired for. Typically, this ID will come from the <c>/user/create</c> response, when the endpoint is invoked with the <c>with_upgraded_user</c> request field set to <c>true</c>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; init; } = default!;

}
