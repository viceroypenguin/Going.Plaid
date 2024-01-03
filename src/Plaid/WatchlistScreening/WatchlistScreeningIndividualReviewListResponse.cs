namespace Going.Plaid.WatchlistScreening;

/// <summary>
/// <para>Paginated list of screening reviews</para>
/// </summary>
public record WatchlistScreeningIndividualReviewListResponse : ResponseBase
{
	/// <summary>
	/// <para>List of screening reviews</para>
	/// </summary>
	[JsonPropertyName("watchlist_screening_reviews")]
	public IReadOnlyList<Entity.WatchlistScreeningReview> WatchlistScreeningReviews { get; init; } = default!;

	/// <summary>
	/// <para>An identifier that determines which page of results you receive.</para>
	/// </summary>
	[JsonPropertyName("next_cursor")]
	public string? NextCursor { get; init; } = default!;

}
