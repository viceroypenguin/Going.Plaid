namespace Going.Plaid.WatchlistScreening;

/// <summary>
/// <para>Request input for listing hits for an individual watchlist screening</para>
/// </summary>
public partial class ListWatchlistScreeningIndividualHitRequest : RequestBase
{
	/// <summary>
	/// <para>ID of the associated screening.</para>
	/// </summary>
	[JsonPropertyName("watchlist_screening_id")]
	public string WatchlistScreeningId { get; set; } = default!;

	/// <summary>
	/// <para>An identifier that determines which page of results you receive.</para>
	/// </summary>
	[JsonPropertyName("cursor")]
	public string? Cursor { get; set; } = default!;
}