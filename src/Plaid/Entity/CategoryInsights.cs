namespace Going.Plaid.Entity;

/// <summary>
/// <para>Insights on a user's top personal finance categories.</para>
/// </summary>
public record CategoryInsights
{
	/// <summary>
	/// <para>List of insights of top primary personal finance categories ranked by outflow.</para>
	/// </summary>
	[JsonPropertyName("primary_category_insights")]
	public IReadOnlyList<Entity.CategoryInsightDetails>? PrimaryCategoryInsights { get; init; } = default!;

	/// <summary>
	/// <para>List of insights of top detailed personal finance categories ranked by outflow.</para>
	/// </summary>
	[JsonPropertyName("detailed_category_insights")]
	public IReadOnlyList<Entity.CategoryInsightDetails>? DetailedCategoryInsights { get; init; } = default!;
}