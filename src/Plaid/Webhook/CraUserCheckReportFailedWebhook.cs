namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when a Check Report has failed to generate. To get more details, call <c>/user/items/get</c> and check for non-null <c>error</c> objects on the associated Items in the response. These <c>error</c> objects will contain more details on why the Item is in an error state and how to resolve it. After resolving the errors, you can try to re-generate the report.</para>
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
	/// <para>The <c>user_id</c> associated with the user whose data is being requested. This is received by calling <c>/user/create</c>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; init; } = default!;

	/// <summary>
	/// <para>A list of <c>item_ids</c> included in the Check Report. Access to this field is in closed beta.</para>
	/// </summary>
	[JsonPropertyName("item_ids")]
	public IReadOnlyList<string>? ItemIds { get; init; } = default!;

}
