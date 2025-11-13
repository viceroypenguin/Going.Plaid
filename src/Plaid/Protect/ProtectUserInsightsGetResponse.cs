namespace Going.Plaid.Protect;

/// <summary>
/// <para>Response object for /protect/user/insights/get</para>
/// </summary>
public record ProtectUserInsightsGetResponse : ResponseBase
{
	/// <summary>
	/// <para>The Plaid User ID. If a <c>client_user_id</c> was provided in the request instead of a <c>user_id</c>, a new <c>user_id</c> will be generated if one doesn't already exist for that <c>client_user_id</c>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; init; } = default!;

	/// <summary>
	/// <para>The latest scored event for a user.</para>
	/// </summary>
	[JsonPropertyName("latest_scored_event")]
	public Entity.LatestScoredEvent? LatestScoredEvent { get; init; } = default!;

	/// <summary>
	/// <para>List of Protect reports associated with this user, limited to the most recent 100 reports in reverse chronological order (newest first).</para>
	/// </summary>
	[JsonPropertyName("reports")]
	public IReadOnlyList<Entity.ProtectReport>? Reports { get; init; } = default!;

}
