namespace Going.Plaid.Categories;

/// <summary>
/// <para>CategoriesGetResponse defines the response schema for <c>/categories/get</c></para>
/// </summary>
public record CategoriesGetResponse : ResponseBase
{
	/// <summary>
	/// <para>An array of all of the transaction categories used by Plaid.</para>
	/// </summary>
	[JsonPropertyName("categories")]
	public IReadOnlyList<Entity.Category> Categories { get; init; } = default!;
}