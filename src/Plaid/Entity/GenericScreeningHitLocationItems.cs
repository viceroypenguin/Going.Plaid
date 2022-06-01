namespace Going.Plaid.Entity;

/// <summary>
/// <para>Analyzed location information for the associated hit</para>
/// </summary>
public record GenericScreeningHitLocationItems
{
	/// <summary>
	/// <para>Summary object reflecting the match result of the associated data</para>
	/// </summary>
	[JsonPropertyName("analysis")]
	public Entity.MatchSummary Analysis { get; init; } = default!;

	/// <summary>
	/// <para>Location information for the associated individual watchlist hit</para>
	/// </summary>
	[JsonPropertyName("data")]
	public Entity.WatchlistScreeningHitLocations Data { get; init; } = default!;
}