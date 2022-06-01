namespace Going.Plaid.Entity;

/// <summary>
/// <para>Summary object reflecting the match result of the associated data</para>
/// </summary>
public record MatchSummary
{
	/// <summary>
	/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
	/// </summary>
	[JsonPropertyName("summary")]
	public Entity.MatchSummaryCode Summary { get; init; } = default!;
}