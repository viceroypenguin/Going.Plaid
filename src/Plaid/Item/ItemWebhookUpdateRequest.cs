namespace Going.Plaid.Item;

/// <summary>
/// <para>ItemWebhookUpdateRequest defines the request schema for <c>/item/webhook/update</c></para>
/// </summary>
public partial class ItemWebhookUpdateRequest : RequestBase
{
	/// <summary>
	/// <para>The new webhook URL to associate with the Item.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string Webhook { get; set; } = default!;
}