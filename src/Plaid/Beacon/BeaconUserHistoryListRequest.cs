namespace Going.Plaid.Beacon;

/// <summary>
/// <para>Request input for listing the history of a Beacon User</para>
/// </summary>
public partial class BeaconUserHistoryListRequest : RequestBase
{
	/// <summary>
	/// <para>ID of the associated Beacon User.</para>
	/// </summary>
	[JsonPropertyName("beacon_user_id")]
	public string BeaconUserId { get; set; } = default!;

	/// <summary>
	/// <para>An identifier that determines which page of results you receive.</para>
	/// </summary>
	[JsonPropertyName("cursor")]
	public string? Cursor { get; set; } = default!;

}
