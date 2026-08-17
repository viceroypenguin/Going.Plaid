namespace Going.Plaid.Entity;

/// <summary>
/// <para>The client-specific impact of an error issue.</para>
/// </summary>
public record BetaIssuesV1IssueImpact
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("affected_new_item_count")]
	public int AffectedNewItemCount { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("affected_existing_item_count")]
	public int AffectedExistingItemCount { get; init; } = default!;

}
