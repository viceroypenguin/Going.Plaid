namespace Going.Plaid.Entity;

/// <summary>
/// <para>Analyzed document information for the associated hit</para>
/// </summary>
public record ScreeningHitDocumentsItems
{
	/// <summary>
	/// <para>Summary object reflecting the match result of the associated data</para>
	/// </summary>
	[JsonPropertyName("analysis")]
	public Entity.MatchSummary? Analysis { get; init; } = default!;

	/// <summary>
	/// <para>An official document, usually issued by a governing body or institution, with an associated identifier.</para>
	/// </summary>
	[JsonPropertyName("data")]
	public Entity.WatchlistScreeningDocument? Data { get; init; } = default!;

}
