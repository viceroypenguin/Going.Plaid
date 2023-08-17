namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object containing information about a link session.</para>
/// </summary>
public record LinkTokenGetSessionsResponse
{
	/// <summary>
	/// <para>The unique ID for the link session.</para>
	/// </summary>
	[JsonPropertyName("link_session_id")]
	public string LinkSessionId { get; init; } = default!;

	/// <summary>
	/// <para>The timestamp at which the link session was first started, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format.</para>
	/// </summary>
	[JsonPropertyName("started_at")]
	public DateTimeOffset? StartedAt { get; init; } = default!;

	/// <summary>
	/// <para>The timestamp at which the link session was finished, if available, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format.</para>
	/// </summary>
	[JsonPropertyName("finished_at")]
	public DateTimeOffset? FinishedAt { get; init; } = default!;

	/// <summary>
	/// <para>An object representing an <a href="https://plaid.com/docs/link/web/#onsuccess">onSuccess</a> callback from Link.</para>
	/// </summary>
	[JsonPropertyName("on_success")]
	public Entity.LinkSessionSuccess? OnSuccess { get; init; } = default!;

	/// <summary>
	/// <para>An object representing an <a href="https://plaid.com/docs/link/web/#onexit">onExit</a> callback from Link.</para>
	/// </summary>
	[JsonPropertyName("on_exit")]
	public Entity.LinkSessionExit? OnExit { get; init; } = default!;
}