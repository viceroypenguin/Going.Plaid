namespace Going.Plaid.Identity;

/// <summary>
/// <para>IdentityMatchListResponse defines the response schema for <c>/identity/match/list</c></para>
/// </summary>
public record IdentityMatchListResponse : ResponseBase
{
	/// <summary>
	/// <para>Page of Link-originated Identity Match attempts ordered by creation time, oldest first.</para>
	/// </summary>
	[JsonPropertyName("identity_match_attempts")]
	public IReadOnlyList<Entity.IdentityMatchListAttempt> IdentityMatchAttempts { get; init; } = default!;

	/// <summary>
	/// <para>Cursor for the next page. Null when there are no more pages.</para>
	/// </summary>
	[JsonPropertyName("next_cursor")]
	public string? NextCursor { get; init; } = default!;

	/// <summary>
	/// <para>Whether more attempts remain in the query window.</para>
	/// </summary>
	[JsonPropertyName("has_more")]
	public bool HasMore { get; init; } = default!;

}
