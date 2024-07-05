namespace Going.Plaid.User;

/// <summary>
/// <para>UserItemsGetResponse defines the response schema for <c>/user/items/get</c></para>
/// </summary>
public record UserItemsGetResponse : ResponseBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("items")]
	public IReadOnlyList<Entity.Item> Items { get; init; } = default!;

}
