namespace Going.Plaid.User;

/// <summary>
/// <para>UserItemsListResponse defines the response schema for <c>/user/items/list</c></para>
/// </summary>
public record UserItemsListResponse : ResponseBase
{
	/// <summary>
	/// <para>The Items associated with the user sorted by <c>created_at</c></para>
	/// </summary>
	[JsonPropertyName("items")]
	public IReadOnlyList<Entity.Item> Items { get; init; } = default!;

	/// <summary>
	/// <para>An identifier to pass in <c>/user/items/list</c> as the optional <c>cursor</c> parameter for the next page of Item results. If this is <c>null</c> then there are no more Items for the given user.</para>
	/// </summary>
	[JsonPropertyName("next_cursor")]
	public string? NextCursor { get; init; } = default!;

}
