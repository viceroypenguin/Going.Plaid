namespace Going.Plaid.Entity;

/// <summary>
/// <para>Summary of how a specific business field matched against data provider results</para>
/// </summary>
public record BusinessFieldMatchSummary
{
	/// <summary>
	/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
	/// </summary>
	[JsonPropertyName("summary")]
	public Entity.MatchSummaryCode Summary { get; init; } = default!;

}
