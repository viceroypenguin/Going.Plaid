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
	/// <para>An identifier to help you connect this object to your internal systems. For example, your database ID corresponding to this object.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string ClientUserId { get; set; } = default!;
}