namespace Going.Plaid.WatchlistScreening;

/// <summary>
/// <para>Request input for creating an individual watchlist screening</para>
/// </summary>
public partial class WatchlistScreeningIndividualCreateRequest : RequestBase
{
	/// <summary>
	/// <para>Search inputs for creating a watchlist screening</para>
	/// </summary>
	[JsonPropertyName("search_terms")]
	public Entity.WatchlistScreeningRequestSearchTerms SearchTerms { get; set; } = default!;

	/// <summary>
	/// <para>A unique ID that identifies the end user in your system. This ID can also be used to associate user-specific data from other Plaid products. Financial Account Matching requires this field and the Link Token Create <c>client_user_id</c> to be consistent. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string? ClientUserId { get; set; } = default!;
}