namespace Going.Plaid.WatchlistScreening;

/// <summary>
/// <para>Paginated list of individual watchlist screening programs</para>
/// </summary>
public record WatchlistScreeningIndividualProgramListResponse : ResponseBase
{
	/// <summary>
	/// <para>List of individual watchlist screening programs</para>
	/// </summary>
	[JsonPropertyName("watchlist_programs")]
	public IReadOnlyList<Entity.IndividualWatchlistProgram> WatchlistPrograms { get; init; } = default!;

	/// <summary>
	/// <para>An identifier that determines which page of results you receive.</para>
	/// </summary>
	[JsonPropertyName("next_cursor")]
	public string? NextCursor { get; init; } = default!;

}
