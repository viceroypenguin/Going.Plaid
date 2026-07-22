namespace Going.Plaid.Item;

/// <summary>
/// <para>ItemGetResponse defines the response schema for <c>/item/get</c> and <c>/item/webhook/update</c></para>
/// </summary>
public record ItemGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Metadata about the Item</para>
	/// </summary>
	[JsonPropertyName("item")]
	public Entity.ItemWithConsentFields Item { get; init; } = default!;

	/// <summary>
	/// <para>An object with information about the status of the Item.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.ItemStatus? Status { get; init; } = default!;

}
