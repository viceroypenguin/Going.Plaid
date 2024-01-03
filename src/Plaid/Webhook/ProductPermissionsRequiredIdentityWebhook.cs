namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when an <c>ACCESS_NOT_GRANTED</c> error is hit for Identity. The error can be resolved by putting the user through update mode with <c>identity</c> in the <c>products</c> array, as well as through the limited beta for update mode Identity product validations.</para>
/// </summary>
public record ProductPermissionsRequiredIdentityWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Identity;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.ProductPermissionsRequired;

	/// <summary>
	/// <para>The <c>item_id</c> of the Item associated with this webhook, warning, or error</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string ItemId { get; init; } = default!;

}
