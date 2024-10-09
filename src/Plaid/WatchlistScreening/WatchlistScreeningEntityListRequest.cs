namespace Going.Plaid.WatchlistScreening;

/// <summary>
/// <para>Request input for listing entity watchlist screenings</para>
/// </summary>
public partial class WatchlistScreeningEntityListRequest : RequestBase
{
	/// <summary>
	/// <para>ID of the associated entity program.</para>
	/// </summary>
	[JsonPropertyName("entity_watchlist_program_id")]
	public string EntityWatchlistProgramId { get; set; } = default!;

	/// <summary>
	/// <para>A unique ID that identifies the end user in your system. This ID can also be used to associate user-specific data from other Plaid products. Financial Account Matching requires this field and the <c>/link/token/create</c> <c>client_user_id</c> to be consistent. Personally identifiable information, such as an email address or phone number, should not be used in the <c>client_user_id</c>.</para>
	/// </summary>
	[JsonPropertyName("client_user_id")]
	public string? ClientUserId { get; set; } = default!;

	/// <summary>
	/// <para>A status enum indicating whether a screening is still pending review, has been rejected, or has been cleared.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.WatchlistScreeningStatus? Status { get; set; } = default!;

	/// <summary>
	/// <para>ID of the associated user. To retrieve the email address or other details of the person corresponding to this id, use <c>/dashboard_user/get</c>.</para>
	/// </summary>
	[JsonPropertyName("assignee")]
	public string? Assignee { get; set; } = default!;

	/// <summary>
	/// <para>An identifier that determines which page of results you receive.</para>
	/// </summary>
	[JsonPropertyName("cursor")]
	public string? Cursor { get; set; } = default!;

}
