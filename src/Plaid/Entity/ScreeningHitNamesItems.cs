namespace Going.Plaid.Entity;

/// <summary>
/// <para>Analyzed name information for the associated hit</para>
/// </summary>
public record ScreeningHitNamesItems
{
	/// <summary>
	/// <para>Summary object reflecting the match result of the associated data</para>
	/// </summary>
	[JsonPropertyName("analysis")]
	public Entity.MatchSummary Analysis { get; init; } = default!;

	/// <summary>
	/// <para>Name information for the associated individual watchlist hit</para>
	/// </summary>
	[JsonPropertyName("data")]
	public Entity.IndividualScreeningHitNames Data { get; init; } = default!;
}