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
	/// <para>The <c>user_id</c> associated with the user whose data is being requested. This is received by calling user/create.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; init; } = default!;

	/// <summary>
	/// <para>A list of <c>item_ids</c> included in the Check Report. Access to this field is in closed beta.</para>
	/// </summary>
	[JsonPropertyName("item_ids")]
	public IReadOnlyList<string>? ItemIds { get; init; } = default!;

}
