namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when an Item has exited the <c>ITEM_LOGIN_REQUIRED</c> state without the user having gone through the update mode flow in your app (this can happen if the user completed the update mode in a different app). If you have messaging that tells the user to complete the update mode flow, you should silence this messaging upon receiving the <c>LOGIN_REPAIRED</c> webhook.</para>
/// </summary>
public record ItemLoginRepairedWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Item;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.LoginRepaired;

	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;
}