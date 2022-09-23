namespace Going.Plaid.WatchlistScreening;

/// <summary>
/// <para>Request input for creating a review for an entity screening</para>
/// </summary>
public partial class WatchlistScreeningEntityReviewCreateRequest : RequestBase
{
	/// <summary>
	/// <para>Hits to mark as a true positive after thorough manual review. These hits will never recur or be updated once dismissed. In most cases, confirmed hits indicate that the customer should be rejected.</para>
	/// </summary>
	[JsonPropertyName("confirmed_hits")]
	public IReadOnlyList<string> ConfirmedHits { get; set; } = default!;

	/// <summary>
	/// <para>Hits to mark as a false positive after thorough manual review. These hits will never recur or be updated once dismissed.</para>
	/// </summary>
	[JsonPropertyName("dismissed_hits")]
	public IReadOnlyList<string> DismissedHits { get; set; } = default!;

	/// <summary>
	/// <para>A comment submitted by a team member as part of reviewing a watchlist screening.</para>
	/// </summary>
	[JsonPropertyName("comment")]
	public string? Comment { get; set; } = default!;

	/// <summary>
	/// <para>ID of the associated entity screening.</para>
	/// </summary>
	[JsonPropertyName("entity_watchlist_screening_id")]
	public string EntityWatchlistScreeningId { get; set; } = default!;
}