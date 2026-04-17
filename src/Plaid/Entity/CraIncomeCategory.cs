namespace Going.Plaid.Entity;

/// <summary>
/// <para>The income category for a given stream. The streams returned in the response will be filtered based on these primary and secondary income categories.</para>
/// <para>See the <a href="https://plaid.com/documents/income-v2-category-taxonomy.csv">Income V2 Category Taxonomy</a> for a full list of income categories.</para>
/// </summary>
public record CraIncomeCategory
{
	/// <summary>
	/// <para>A high level category that communicates the broad category of the stream.</para>
	/// </summary>
	[JsonPropertyName("primary")]
	public string Primary { get; init; } = default!;

	/// <summary>
	/// <para>A granular category conveying the stream's intent.</para>
	/// </summary>
	[JsonPropertyName("secondary")]
	public string Secondary { get; init; } = default!;

}
