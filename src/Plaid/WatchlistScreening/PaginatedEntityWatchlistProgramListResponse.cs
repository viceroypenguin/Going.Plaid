namespace Going.Plaid.WatchlistScreening;

/// <summary>
/// <para>Paginated list of entity watchlist screening programs</para>
/// </summary>
public record PaginatedEntityWatchlistProgramListResponse : ResponseBase
{
	/// <summary>
	/// <para>List of entity watchlist screening programs</para>
	/// </summary>
	[JsonPropertyName("entity_watchlist_programs")]
	public IReadOnlyList<Entity.EntityWatchlistProgram> EntityWatchlistPrograms { get; init; } = default!;

	/// <summary>
	/// <para>An identifier that determines which page of results you receive.</para>
	/// </summary>
	[JsonPropertyName("next_cursor")]
	public string? NextCursor { get; init; } = default!;
}