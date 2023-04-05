namespace Going.Plaid.Entity;

/// <summary>
/// <para>Metadata and results for a Link session</para>
/// </summary>
public record CreditSession
{
	/// <summary>
	/// <para>The unique identifier associated with the Link session. This identifier matches the <c>link_session_id</c> returned in the onSuccess/onExit callbacks.</para>
	/// </summary>
	[JsonPropertyName("link_session_id")]
	public string? LinkSessionId { get; init; } = default!;

	/// <summary>
	/// <para>The time when the Link session started</para>
	/// </summary>
	[JsonPropertyName("session_start_time")]
	public DateTimeOffset? SessionStartTime { get; init; } = default!;

	/// <summary>
	/// <para>The set of results for a Link session.</para>
	/// </summary>
	[JsonPropertyName("results")]
	public Entity.CreditSessionResults? Results { get; init; } = default!;

	/// <summary>
	/// <para>The set of errors that occurred during the Link session.</para>
	/// </summary>
	[JsonPropertyName("errors")]
	public IReadOnlyList<Entity.CreditSessionError>? Errors { get; init; } = default!;
}