namespace Going.Plaid.WatchlistScreening;

/// <summary>
/// <para>Request input for fetching a entity watchlist screening</para>
/// </summary>
public partial class GetEntityWatchlistScreeningRequest : RequestBase
{
	/// <summary>
	/// <para>ID of the associated entity screening.</para>
	/// </summary>
	[JsonPropertyName("entity_watchlist_screening_id")]
	public string EntityWatchlistScreeningId { get; set; } = default!;
}