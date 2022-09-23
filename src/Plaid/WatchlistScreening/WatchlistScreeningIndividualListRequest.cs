namespace Going.Plaid.WatchlistScreening;

/// <summary>
/// <para>Request input for listinging watchlist screenings for individuals</para>
/// </summary>
public partial class WatchlistScreeningIndividualListRequest : RequestBase
{
	/// <summary>
	/// <para>ID of the associated program.</para>
	/// </summary>
	[JsonPropertyName("watchlist_program_id")]
	public string WatchlistProgramId { get; set; } = default!;

	/// <summary>
	/// <para>An identifier to help you connect this object to your internal systems. For example, your database ID corresponding to this object.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string ClientUserId { get; set; } = default!;

	/// <summary>
	/// <para>A status enum indicating whether a screening is still pending review, has been rejected, or has been cleared.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.WatchlistScreeningStatus Status { get; set; } = default!;

	/// <summary>
	/// <para>ID of the associated user.</para>
	/// </summary>
	[JsonPropertyName("assignee")]
	public string Assignee { get; set; } = default!;

	/// <summary>
	/// <para>An identifier that determines which page of results you receive.</para>
	/// </summary>
	[JsonPropertyName("cursor")]
	public string? Cursor { get; set; } = default!;
}