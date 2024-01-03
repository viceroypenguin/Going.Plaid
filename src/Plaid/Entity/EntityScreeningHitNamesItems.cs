namespace Going.Plaid.Entity;

/// <summary>
/// <para>Analyzed names for the associated hit</para>
/// </summary>
public record EntityScreeningHitNamesItems
{
	/// <summary>
	/// <para>Summary object reflecting the match result of the associated data</para>
	/// </summary>
	[JsonPropertyName("analysis")]
	public Entity.MatchSummary? Analysis { get; init; } = default!;

	/// <summary>
	/// <para>Name information for the associated entity watchlist hit</para>
	/// </summary>
	[JsonPropertyName("data")]
	public Entity.EntityScreeningHitNames? Data { get; init; } = default!;

}
