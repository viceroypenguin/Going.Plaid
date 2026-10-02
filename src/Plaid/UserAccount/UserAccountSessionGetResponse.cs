namespace Going.Plaid.UserAccount;

/// <summary>
/// <para>UserAccountSessionGetResponse defines the response schema for <c>/user_account/session/get</c></para>
/// </summary>
public record UserAccountSessionGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Overall IDV status for the session. Omitted when IDV status retrieval is disabled, no verification exists, or its status is unavailable. Use the IDV endpoints for detailed results.</para>
	/// </summary>
	[JsonPropertyName("idv_session_status")]
	public Entity.IdentityVerificationStatus? IdvSessionStatus { get; init; } = default!;

	/// <summary>
	/// <para>The Link session identifier associated with this session. Null for sessions without a valid Link session identifier.</para>
	/// </summary>
	[JsonPropertyName("link_session_id")]
	public string? LinkSessionId { get; init; } = default!;

	/// <summary>
	/// <para>The identity data permissioned by the end user during the authorization flow.</para>
	/// </summary>
	[JsonPropertyName("identity")]
	public Entity.UserAccountIdentity? Identity { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("items")]
	public IReadOnlyList<Entity.UserAccountItem> Items { get; init; } = default!;

	/// <summary>
	/// <para>Statistics tracking the number of edits made to identity fields over various time periods.</para>
	/// </summary>
	[JsonPropertyName("identity_edit_history")]
	public Entity.UserAccountIdentityEditHistory? IdentityEditHistory { get; init; } = default!;

}
