namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object containing information about a link session. Session data will be provided for up to six hours after the session has ended.</para>
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
	/// <para>An object representing an <a href="https://plaid.com/docs/link/web/#onsuccess">onSuccess</a> callback from Link. This object has been deprecated in favor of the newer <a href="https://plaid.com/docs/api/link/#link-token-get-response-link-sessions-results-item-add-results"><c>results.item_add_result</c></a>, which can support multiple public tokens in a single Link session.</para>
	/// </summary>
	[JsonPropertyName("on_success")]
	[Obsolete]
	public Entity.LinkSessionSuccess? OnSuccess { get; init; } = default!;

	/// <summary>
	/// <para>An object representing an <a href="https://plaid.com/docs/link/web/#onexit">onExit</a> callback from Link. This field has been deprecated in favor of <a href="https://plaid.com/docs/api/link/#link-token-get-response-link-sessions-exit"><c>exit</c></a>, for improved naming consistency.</para>
	/// </summary>
	[JsonPropertyName("on_exit")]
	[Obsolete]
	public Entity.LinkSessionExitDeprecated? OnExit { get; init; } = default!;

	/// <summary>
	/// <para>An object representing an <a href="https://plaid.com/docs/link/web/#onexit">onExit</a> callback from Link.</para>
	/// </summary>
	[JsonPropertyName("exit")]
	public Entity.LinkSessionExit? Exit { get; init; } = default!;

	/// <summary>
	/// <para>List of customer-related Link events</para>
	/// </summary>
	[JsonPropertyName("events")]
	public IReadOnlyList<Entity.LinkEvent>? Events { get; init; } = default!;

	/// <summary>
	/// <para>The set of results for a Link session.</para>
	/// </summary>
	[JsonPropertyName("results")]
	public Entity.LinkSessionResults? Results { get; init; } = default!;

}
