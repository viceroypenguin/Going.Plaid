namespace Going.Plaid.Entity;

/// <summary>
/// <para>Data from a government watchlist that has been attached to the screening.</para>
/// </summary>
public record EntityWatchlistScreeningHit
{
	/// <summary>
	/// <para>ID of the associated entity screening hit.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; init; } = default!;

	/// <summary>
	/// <para>The current state of review. All watchlist screening hits begin in a <c>pending_review</c> state but can be changed by creating a review. When a hit is in the <c>pending_review</c> state, it will always show the latest version of the watchlist data Plaid has available and be compared against the latest customer information saved in the watchlist screening. Once a hit has been marked as <c>confirmed</c> or <c>dismissed</c> it will no longer be updated so that the state is as it was when the review was first conducted.</para>
	/// </summary>
	[JsonPropertyName("review_status")]
	public Entity.WatchlistScreeningHitStatus ReviewStatus { get; init; } = default!;

	/// <summary>
	/// <para>An ISO8601 formatted timestamp.</para>
	/// </summary>
	[JsonPropertyName("first_active")]
	public DateTimeOffset FirstActive { get; init; } = default!;

	/// <summary>
	/// <para>An ISO8601 formatted timestamp.</para>
	/// </summary>
	[JsonPropertyName("inactive_since")]
	public DateTimeOffset? InactiveSince { get; init; } = default!;

	/// <summary>
	/// <para>An ISO8601 formatted timestamp.</para>
	/// </summary>
	[JsonPropertyName("historical_since")]
	public DateTimeOffset? HistoricalSince { get; init; } = default!;

	/// <summary>
	/// <para>Shorthand identifier for a specific screening list for entities.</para>
	/// </summary>
	[JsonPropertyName("list_code")]
	public Entity.EntityWatchlistCode ListCode { get; init; } = default!;

	/// <summary>
	/// <para>A universal identifier for a watchlist individual that is stable across searches and updates.</para>
	/// </summary>
	[JsonPropertyName("plaid_uid")]
	public string PlaidUid { get; init; } = default!;

	/// <summary>
	/// <para>The identifier provided by the source sanction or watchlist. When one is not provided by the source, this is <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("source_uid")]
	public string? SourceUid { get; init; } = default!;

	/// <summary>
	/// <para>Analysis information describing why a screening hit matched the provided entity information</para>
	/// </summary>
	[JsonPropertyName("analysis")]
	public Entity.EntityScreeningHitAnalysis Analysis { get; init; } = default!;

	/// <summary>
	/// <para>Information associated with the entity watchlist hit</para>
	/// </summary>
	[JsonPropertyName("data")]
	public Entity.EntityScreeningHitData Data { get; init; } = default!;
}