namespace Going.Plaid.Beacon;

/// <summary>
/// <para>The response schema for <c>/beacon/user/history/list</c></para>
/// </summary>
public record BeaconUserHistoryListResponse : ResponseBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("beacon_users")]
	public IReadOnlyList<Entity.BeaconUser> BeaconUsers { get; init; } = default!;

	/// <summary>
	/// <para>An identifier that determines which page of results you receive.</para>
	/// </summary>
	[JsonPropertyName("next_cursor")]
	public string? NextCursor { get; init; } = default!;

}
