namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when products for the Check Report are ready to be retrieved</para>
/// </summary>
public record CraCheckReportReadyWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.CheckReport;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.CheckReportReady;

	/// <summary>
	/// <para>The <c>user_id</c> corresponding to the user the webhook has fired for.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; init; } = default!;

	/// <summary>
	/// <para>A list of <c>item_ids</c> that is included in the Check Report.</para>
	/// </summary>
	[JsonPropertyName("item_ids")]
	public IReadOnlyList<string>? ItemIds { get; init; } = default!;

}
