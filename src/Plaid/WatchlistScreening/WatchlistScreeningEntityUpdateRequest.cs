namespace Going.Plaid.WatchlistScreening;

/// <summary>
/// <para>Request input for editing an entity watchlist screening</para>
/// </summary>
public partial class WatchlistScreeningEntityUpdateRequest : RequestBase
{
	/// <summary>
	/// <para>ID of the associated entity screening.</para>
	/// </summary>
	[JsonPropertyName("entity_watchlist_screening_id")]
	public string EntityWatchlistScreeningId { get; set; } = default!;

	/// <summary>
	/// <para>Search terms for editing an entity watchlist screening</para>
	/// </summary>
	[JsonPropertyName("search_terms")]
	public Entity.UpdateEntityScreeningRequestSearchTerms? SearchTerms { get; set; } = default!;

	/// <summary>
	/// <para>ID of the associated user.</para>
	/// </summary>
	[JsonPropertyName("assignee")]
	public string? Assignee { get; set; } = default!;

	/// <summary>
	/// <para>A status enum indicating whether a screening is still pending review, has been rejected, or has been cleared.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.WatchlistScreeningStatus? Status { get; set; } = default!;

	/// <summary>
	/// <para>An identifier to help you connect this object to your internal systems. For example, your database ID corresponding to this object.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string? ClientUserId { get; set; } = default!;

	/// <summary>
	/// <para>A list of fields to reset back to null</para>
	/// </summary>
	[JsonPropertyName("reset_fields")]
	public IReadOnlyList<Entity.WatchlistScreeningEntityUpdateRequestResettableField>? ResetFields { get; set; } = default!;
}