namespace Going.Plaid.WatchlistScreening;

/// <summary>
/// <para>The screening object allows you to represent a customer in your system, update their profile, and search for them on various watchlists. Note: Rejected customers will not receive new hits, regardless of program configuration.</para>
/// </summary>
public record WatchlistScreeningIndividualUpdateResponse : ResponseBase
{
	/// <summary>
	/// <para>ID of the associated screening.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; init; } = default!;

	/// <summary>
	/// <para>Search terms for creating an individual watchlist screening</para>
	/// </summary>
	[JsonPropertyName("search_terms")]
	public Entity.WatchlistScreeningSearchTerms SearchTerms { get; init; } = default!;

	/// <summary>
	/// <para>ID of the associated user.</para>
	/// </summary>
	[JsonPropertyName("assignee")]
	public string? Assignee { get; init; } = default!;

	/// <summary>
	/// <para>A status enum indicating whether a screening is still pending review, has been rejected, or has been cleared.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.WatchlistScreeningStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>An identifier to help you connect this object to your internal systems. For example, your database ID corresponding to this object.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string? ClientUserId { get; init; } = default!;

	/// <summary>
	/// <para>Information about the last change made to the parent object specifying what caused the change as well as when it occurred.</para>
	/// </summary>
	[JsonPropertyName("audit_trail")]
	public Entity.WatchlistScreeningAuditTrail AuditTrail { get; init; } = default!;
}