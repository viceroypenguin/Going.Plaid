namespace Going.Plaid.Entity;

/// <summary>
/// <para>Information describing a transaction category</para>
/// </summary>
public record Category
{
	/// <summary>
	/// <para>An identifying number for the category. <c>category_id</c> is a Plaid-specific identifier and does not necessarily correspond to merchant category codes.</para>
	/// </summary>
	[JsonPropertyName("category_id")]
	public string CategoryId { get; init; } = default!;

	/// <summary>
	/// <para><c>place</c> for physical transactions or <c>special</c> for other transactions such as bank charges.</para>
	/// </summary>
	[JsonPropertyName("group")]
	public string Group { get; init; } = default!;

	/// <summary>
	/// <para>A hierarchical array of the categories to which this <c>category_id</c> belongs.</para>
	/// </summary>
	[JsonPropertyName("hierarchy")]
	public IReadOnlyList<string> Hierarchy { get; init; } = default!;
}