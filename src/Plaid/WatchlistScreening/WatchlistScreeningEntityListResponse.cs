namespace Going.Plaid.WatchlistScreening;

/// <summary>
/// <para>Paginated list of entity watchlist screenings</para>
/// </summary>
public record WatchlistScreeningEntityListResponse : ResponseBase
{
	/// <summary>
	/// <para>List of entity watchlist screening</para>
	/// </summary>
	[JsonPropertyName("entity_watchlist_screenings")]
	public IReadOnlyList<Entity.EntityWatchlistScreening> EntityWatchlistScreenings { get; init; } = default!;

	/// <summary>
	/// <para>An identifier that determines which page of results you receive.</para>
	/// </summary>
	[JsonPropertyName("next_cursor")]
	public string? NextCursor { get; init; } = default!;

}
