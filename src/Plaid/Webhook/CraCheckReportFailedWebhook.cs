namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when a Check Report has failed to generate. To get more details, call <c>/user/items/get</c> and check for non-null <c>error</c> objects on the associated Items in the response. These <c>error</c> objects will contain more details on why the Item is in an error state and how to resolve it. After resolving the errors, you can try to re-generate the report.</para>
/// </summary>
public record CraCheckReportFailedWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.CheckReport;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.CheckReportFailed;

	/// <summary>
	/// <para>The <c>user_id</c> corresponding to the user the webhook has fired for.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; init; } = default!;

}
