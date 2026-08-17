namespace Going.Plaid.Beta;

/// <summary>
/// <para>BetaWebhookEventsListResponse defines the response schema for <c>/beta/webhook_events/list</c></para>
/// </summary>
public record BetaWebhookEventsListResponse : ResponseBase
{
	/// <summary>
	/// <para>Webhook events sent to the calling client.</para>
	/// </summary>
	[JsonPropertyName("webhook_events")]
	public IReadOnlyList<Entity.WebhookEvent> WebhookEvents { get; init; } = default!;

	/// <summary>
	/// <para>Indicates whether another page of webhook events is available.</para>
	/// </summary>
	[JsonPropertyName("has_more")]
	public bool HasMore { get; init; } = default!;

	/// <summary>
	/// <para>Cursor to pass as <c>cursor</c> on a later <c>/beta/webhook_events/list</c> request to continue</para>
	/// <para>forward. Persist and reuse this value even when <c>has_more</c> is <c>false</c> so the next poll</para>
	/// <para>only returns newer events.</para>
	/// </summary>
	[JsonPropertyName("next_cursor")]
	public string NextCursor { get; init; } = default!;

}
