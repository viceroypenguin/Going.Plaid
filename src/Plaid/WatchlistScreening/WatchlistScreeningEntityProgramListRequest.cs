namespace Going.Plaid.WatchlistScreening;

/// <summary>
/// <para>Request input for listing entity watchlist screening programs</para>
/// </summary>
public partial class WatchlistScreeningEntityProgramListRequest : RequestBase
{
	/// <summary>
	/// <para>An identifier that determines which page of results you receive.</para>
	/// </summary>
	[JsonPropertyName("cursor")]
	public string? Cursor { get; set; } = default!;

}
