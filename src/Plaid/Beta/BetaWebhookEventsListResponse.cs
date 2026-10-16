namespace Going.Plaid.Beta;

/// <summary>
/// <para>BetaWebhookEventsListResponse defines the response schema for <c>/beta/webhook_events/list</c></para>
/// </summary>
public record BetaWebhookEventsListResponse : ResponseBase
{
	/// <summary>
	/// <para>Webhook events for your account.</para>
	/// </summary>
	[JsonPropertyName("webhook_events")]
	public IReadOnlyList<Entity.WebhookEvent> WebhookEvents { get; init; } = default!;

	/// <summary>
	/// <para>Indicates whether another page of webhook events is available.</para>
	/// </summary>
	[JsonPropertyName("has_more")]
	public bool HasMore { get; init; } = default!;

	/// <summary>
	/// <para>The cursor to send as <c>cursor</c> in your next request. Store it even when <c>has_more</c> is <c>false</c>.</para>
	/// </summary>
	[JsonPropertyName("next_cursor")]
	public string NextCursor { get; init; } = default!;

}
