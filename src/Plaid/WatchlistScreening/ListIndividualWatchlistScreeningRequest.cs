namespace Going.Plaid.WatchlistScreening;

/// <summary>
/// <para>Request input for listinging watchlist screenings for individuals</para>
/// </summary>
public partial class ListIndividualWatchlistScreeningRequest : RequestBase
{
	/// <summary>
	/// <para>ID of the associated program.</para>
	/// </summary>
	[JsonPropertyName("watchlist_program_id")]
	public string WatchlistProgramId { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string? ClientUserId { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("status")]
	public string? Status { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("assignee")]
	public string? Assignee { get; set; } = default!;

	/// <summary>
	/// <para>An identifier that determines which page of results you receive.</para>
	/// </summary>
	[JsonPropertyName("cursor")]
	public string? Cursor { get; set; } = default!;
}