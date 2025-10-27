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
	/// <para>An object representing an <a href="https://plaid.com/docs/link/web/#onsuccess">onSuccess</a> callback from Link. This field is returned only for legacy integrations and is deprecated in favor of <a href="https://plaid.com/docs/api/link/#link-token-get-response-link-sessions-results-item-add-results"><c>results.item_add_results</c></a> which can support multiple public tokens in a single Link session, for flows such as multi-Item Link. If you are receiving <c>on_success</c>, contact your Account Manager to migrate to <c>results.item_add_results</c> instead.</para>
	/// </summary>
	[JsonPropertyName("on_success")]
	[Obsolete]
	public Entity.LinkSessionSuccess? OnSuccess { get; init; } = default!;

	/// <summary>
	/// <para>An object representing an <a href="https://plaid.com/docs/link/web/#onexit">onExit</a> callback from Link. This field is returned only for legacy implementations and has been deprecated in favor of <a href="https://plaid.com/docs/api/link/#link-token-get-response-link-sessions-exit"><c>exit</c></a>, for improved naming consistency. If you are receiving this field, contact your Account Manager to migrate to the newer <c>exit</c> field.</para>
	/// </summary>
	[JsonPropertyName("on_exit")]
	[Obsolete]
	public Entity.LinkSessionExitDeprecated? OnExit { get; init; } = default!;

	/// <summary>
	/// <para>An object representing an <a href="https://plaid.com/docs/link/web/#onexit">onExit</a> callback from Link. If you are not receiving this field and are instead receiving the deprecated <c>on_exit</c> field, contact your Account Manager to update your integration.</para>
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
