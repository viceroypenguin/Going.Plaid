namespace Going.Plaid.WatchlistScreening;

/// <summary>
/// <para>Paginated list of individual watchlist screenings.</para>
/// </summary>
public record WatchlistScreeningIndividualHistoryListResponse : ResponseBase
{
	/// <summary>
	/// <para>List of individual watchlist screenings</para>
	/// </summary>
	[JsonPropertyName("watchlist_screenings")]
	public IReadOnlyList<Entity.WatchlistScreeningIndividual> WatchlistScreenings { get; init; } = default!;

	/// <summary>
	/// <para>An identifier that determines which page of results you receive.</para>
	/// </summary>
	[JsonPropertyName("next_cursor")]
	public string? NextCursor { get; init; } = default!;

}
