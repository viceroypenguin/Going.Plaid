namespace Going.Plaid.WatchlistScreening;

/// <summary>
/// <para>Request input for fetching an individual watchlist screening</para>
/// </summary>
public partial class WatchlistScreeningIndividualGetRequest : RequestBase
{
	/// <summary>
	/// <para>ID of the associated screening.</para>
	/// </summary>
	[JsonPropertyName("watchlist_screening_id")]
	public string WatchlistScreeningId { get; set; } = default!;

}
