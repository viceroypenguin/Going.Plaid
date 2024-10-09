namespace Going.Plaid.WatchlistScreening;

/// <summary>
/// <para>The screening object allows you to represent a customer in your system, update their profile, and search for them on various watchlists. Note: Rejected customers will not receive new hits, regardless of program configuration.</para>
/// </summary>
public record WatchlistScreeningIndividualCreateResponse : ResponseBase
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
	/// <para>ID of the associated user. To retrieve the email address or other details of the person corresponding to this id, use <c>/dashboard_user/get</c>.</para>
	/// </summary>
	[JsonPropertyName("assignee")]
	public string? Assignee { get; init; } = default!;

	/// <summary>
	/// <para>A status enum indicating whether a screening is still pending review, has been rejected, or has been cleared.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.WatchlistScreeningStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>A unique ID that identifies the end user in your system. This ID can also be used to associate user-specific data from other Plaid products. Financial Account Matching requires this field and the <c>/link/token/create</c> <c>client_user_id</c> to be consistent. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string? ClientUserId { get; init; } = default!;

	/// <summary>
	/// <para>Information about the last change made to the parent object specifying what caused the change as well as when it occurred.</para>
	/// </summary>
	[JsonPropertyName("audit_trail")]
	public Entity.WatchlistScreeningAuditTrail AuditTrail { get; init; } = default!;

}
