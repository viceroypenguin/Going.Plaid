namespace Going.Plaid.WatchlistScreening;

/// <summary>
/// <para>Request input for fetching an entity watchlist program</para>
/// </summary>
public partial class GetWatchlistScreeningEntityProgramRequest : RequestBase
{
	/// <summary>
	/// <para>ID of the associated entity program.</para>
	/// </summary>
	[JsonPropertyName("entity_watchlist_program_id")]
	public string EntityWatchlistProgramId { get; set; } = default!;
}