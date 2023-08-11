namespace Going.Plaid.WatchlistScreening;

/// <summary>
/// <para>Request input for creating an entity screening review</para>
/// </summary>
public partial class WatchlistScreeningEntityCreateRequest : RequestBase
{
	/// <summary>
	/// <para>Search inputs for creating an entity watchlist screening</para>
	/// </summary>
	[JsonPropertyName("search_terms")]
	public Entity.EntityWatchlistSearchTerms SearchTerms { get; set; } = default!;

	/// <summary>
	/// <para>A unique ID that identifies the end user in your system. This ID can also be used to associate user-specific data from other Plaid products. Financial Account Matching requires this field and the <c>/link/token/create</c> <c>client_user_id</c> to be consistent. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string? ClientUserId { get; set; } = default!;
}