namespace Going.Plaid.Item;

/// <summary>
/// <para>ItemWebhookUpdateResponse defines the response schema for <c>/item/webhook/update</c></para>
/// </summary>
public record ItemWebhookUpdateResponse : ResponseBase
{
	/// <summary>
	/// <para>Metadata about the Item.</para>
	/// </summary>
	[JsonPropertyName("item")]
	public Entity.Item Item { get; init; } = default!;

}
