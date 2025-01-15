namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when a Check Report upgrade attempt has failed</para>
/// </summary>
public record CraUpgradeFailedWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.CheckReport;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.UpgradeFailed;

	/// <summary>
	/// <para>The <c>user_id</c> corresponding to the user the webhook has fired for.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; init; } = default!;

	/// <summary>
	/// <para>An array of <c>item_id</c>s for items that failed to be upgraded by a Check Report upgrade attempt.</para>
	/// </summary>
	[JsonPropertyName("item_ids")]
	public IReadOnlyList<string> ItemIds { get; init; } = default!;

}
