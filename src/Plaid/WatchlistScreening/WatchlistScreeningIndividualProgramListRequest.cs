namespace Going.Plaid.WatchlistScreening;

/// <summary>
/// <para>Request input for listing watchlist screening programs for individuals</para>
/// </summary>
public partial class WatchlistScreeningIndividualProgramListRequest : RequestBase
{
	/// <summary>
	/// <para>An identifier that determines which page of results you receive.</para>
	/// </summary>
	[JsonPropertyName("cursor")]
	public string? Cursor { get; set; } = default!;
}