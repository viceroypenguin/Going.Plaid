namespace Going.Plaid.Entity;

/// <summary>
/// <para>Analyzed URLs for the associated hit</para>
/// </summary>
public record EntityScreeningHitUrlsItems
{
	/// <summary>
	/// <para>Summary object reflecting the match result of the associated data</para>
	/// </summary>
	[JsonPropertyName("analysis")]
	public Entity.MatchSummary Analysis { get; init; } = default!;

	/// <summary>
	/// <para>URLs associated with the entity screening hit</para>
	/// </summary>
	[JsonPropertyName("data")]
	public Entity.EntityScreeningHitUrls Data { get; init; } = default!;
}