namespace Going.Plaid.WatchlistScreening;

/// <summary>
/// <para>Request input for editing an individual watchlist screening</para>
/// </summary>
public partial class WatchlistScreeningIndividualUpdateRequest : RequestBase
{
	/// <summary>
	/// <para>ID of the associated screening.</para>
	/// </summary>
	[JsonPropertyName("watchlist_screening_id")]
	public string WatchlistScreeningId { get; set; } = default!;

	/// <summary>
	/// <para>Search terms for editing an individual watchlist screening</para>
	/// </summary>
	[JsonPropertyName("search_terms")]
	public Entity.UpdateIndividualScreeningRequestSearchTerms? SearchTerms { get; set; } = default!;

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
	/// <para>A unique ID that identifies the end user in your system. This ID can also be used to associate user-specific data from other Plaid products. Financial Account Matching requires this field and the Link Token Create <c>client_user_id</c> to be consistent. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string? ClientUserId { get; set; } = default!;

	/// <summary>
	/// <para>A list of fields to reset back to null</para>
	/// </summary>
	[JsonPropertyName("reset_fields")]
	public IReadOnlyList<Entity.WatchlistScreeningIndividualUpdateRequestResettableField>? ResetFields { get; set; } = default!;
}