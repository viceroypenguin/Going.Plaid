namespace Going.Plaid.WatchlistScreening;

/// <summary>
/// <para>Request input for editing an entity watchlist screening</para>
/// </summary>
public partial class UpdateEntityScreeningRequest : RequestBase
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
	/// 
	/// </summary>
	[JsonPropertyName("assignee")]
	public string? Assignee { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("status")]
	public string? Status { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string? ClientUserId { get; set; } = default!;

	/// <summary>
	/// <para>A list of fields to reset back to null</para>
	/// </summary>
	[JsonPropertyName("reset_fields")]
	public IReadOnlyList<Entity.UpdateEntityScreeningRequestResettableField>? ResetFields { get; set; } = default!;
}