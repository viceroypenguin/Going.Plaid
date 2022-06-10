namespace Going.Plaid.WatchlistScreening;

/// <summary>
/// <para>Paginated list of entity watchlist screening reviews</para>
/// </summary>
public record PaginatedEntityWatchlistScreeningReviewListResponse : ResponseBase
{
	/// <summary>
	/// <para>List of entity watchlist screening reviews</para>
	/// </summary>
	[JsonPropertyName("entity_watchlist_screening_reviews")]
	public IReadOnlyList<Entity.EntityWatchlistScreeningReview> EntityWatchlistScreeningReviews { get; init; } = default!;

	/// <summary>
	/// <para>An identifier that determines which page of results you receive.</para>
	/// </summary>
	[JsonPropertyName("next_cursor")]
	public string? NextCursor { get; init; } = default!;
}