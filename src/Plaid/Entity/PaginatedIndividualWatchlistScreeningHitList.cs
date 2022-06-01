namespace Going.Plaid.Entity;

/// <summary>
/// <para>Paginated list of individual watchlist screening hits</para>
/// </summary>
public record PaginatedIndividualWatchlistScreeningHitList : ResponseBase
{
	/// <summary>
	/// <para>List of individual watchlist screening hits</para>
	/// </summary>
	[JsonPropertyName("watchlist_screening_hits")]
	public IReadOnlyList<Entity.WatchlistScreeningHit> WatchlistScreeningHits { get; init; } = default!;

	/// <summary>
	/// <para>An identifier that determines which page of results you receive.</para>
	/// </summary>
	[JsonPropertyName("next_cursor")]
	public string? NextCursor { get; init; } = default!;
}