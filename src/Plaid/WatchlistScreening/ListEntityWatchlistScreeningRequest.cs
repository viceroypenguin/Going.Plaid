namespace Going.Plaid.WatchlistScreening;

/// <summary>
/// <para>Request input for listing entity watchlist screenings</para>
/// </summary>
public partial class ListEntityWatchlistScreeningRequest : RequestBase
{
	/// <summary>
	/// <para>ID of the associated entity program.</para>
	/// </summary>
	[JsonPropertyName("entity_watchlist_program_id")]
	public string EntityWatchlistProgramId { get; set; } = default!;

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