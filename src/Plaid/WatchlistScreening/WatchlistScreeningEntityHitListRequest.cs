namespace Going.Plaid.WatchlistScreening;

/// <summary>
/// <para>Request input for listing hits for an entity watchlist screening</para>
/// </summary>
public partial class WatchlistScreeningEntityHitListRequest : RequestBase
{
	/// <summary>
	/// <para>ID of the associated entity screening.</para>
	/// </summary>
	[JsonPropertyName("entity_watchlist_screening_id")]
	public string EntityWatchlistScreeningId { get; set; } = default!;

	/// <summary>
	/// <para>An identifier that determines which page of results you receive.</para>
	/// </summary>
	[JsonPropertyName("cursor")]
	public string? Cursor { get; set; } = default!;
}