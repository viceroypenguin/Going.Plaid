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
	/// <para>Information about the last successful and failed transactions update for the Item.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.ItemStatus? Status { get; init; } = default!;

}
