namespace Going.Plaid.Entity;

/// <summary>
/// <para>Paginated list of entity watchlist screening hits</para>
/// </summary>
public record PaginatedEntityWatchlistScreeningHitList : ResponseBase
{
	/// <summary>
	/// <para>List of entity watchlist screening hits</para>
	/// </summary>
	[JsonPropertyName("entity_watchlist_screening_hits")]
	public IReadOnlyList<Entity.EntityWatchlistScreeningHit> EntityWatchlistScreeningHits { get; init; } = default!;

	/// <summary>
	/// <para>An identifier that determines which page of results you receive.</para>
	/// </summary>
	[JsonPropertyName("next_cursor")]
	public string? NextCursor { get; init; } = default!;
}