namespace Going.Plaid.WatchlistScreening;

/// <summary>
/// <para>A review submitted by a team member for an individual watchlist screening. A review can be either a comment on the current screening state, actions taken</para>
/// <para>against hits attached to the watchlist screening, or both.</para>
/// </summary>
public record WatchlistScreeningIndividualReviewCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>ID of the associated review.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; init; } = default!;

	/// <summary>
	/// <para>Hits marked as a true positive after thorough manual review. These hits will never recur or be updated once dismissed. In most cases, confirmed hits indicate that the customer should be rejected.</para>
	/// </summary>
	[JsonPropertyName("confirmed_hits")]
	public IReadOnlyList<string> ConfirmedHits { get; init; } = default!;

	/// <summary>
	/// <para>Hits marked as a false positive after thorough manual review. These hits will never recur or be updated once dismissed.</para>
	/// </summary>
	[JsonPropertyName("dismissed_hits")]
	public IReadOnlyList<string> DismissedHits { get; init; } = default!;

	/// <summary>
	/// <para>A comment submitted by a team member as part of reviewing a watchlist screening.</para>
	/// </summary>
	[JsonPropertyName("comment")]
	public string? Comment { get; init; } = default!;

	/// <summary>
	/// <para>Information about the last change made to the parent object specifying what caused the change as well as when it occurred.</para>
	/// </summary>
	[JsonPropertyName("audit_trail")]
	public Entity.WatchlistScreeningAuditTrail AuditTrail { get; init; } = default!;
}