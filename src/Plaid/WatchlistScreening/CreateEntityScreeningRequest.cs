namespace Going.Plaid.WatchlistScreening;

/// <summary>
/// <para>Request input for creating an entity screening review</para>
/// </summary>
public partial class CreateEntityScreeningRequest : RequestBase
{
	/// <summary>
	/// <para>Search inputs for creating an entity watchlist screening</para>
	/// </summary>
	[JsonPropertyName("search_terms")]
	public Entity.EntityWatchlistSearchTerms SearchTerms { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string? ClientUserId { get; set; } = default!;
}