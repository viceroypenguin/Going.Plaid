namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when an Item login is repaired and the Item no longer needs to go through update mode. This will occur when the user completed the update mode flow for the Item, either in your application or in another Plaid-connected app. If you have messaging that tells the user to complete the update mode flow (such as in-app banners or out-of-band notifications) you should silence this messaging upon receiving the <c>LOGIN_REPAIRED</c> webhook.</para>
/// </summary>
public record ItemLoginRepairedWebhook : WebhookBase
{
	/// <inheritdoc />
	public override WebhookType WebhookType => WebhookType.Item;

	/// <inheritdoc />
	public override WebhookCode WebhookCode => WebhookCode.LoginRepaired;

	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;
}