namespace Going.Plaid.Webhook;

/// <summary>
/// <para>Fired when there has been a new user event. The webhook payload contains limited information about the event. For full event details, call <a href="https://plaid.com/docs/api/products/protect/#protecteventget"><c>/protect/event/get</c></a>.</para>
/// </summary>
public record ProtectUserEventWebhook : WebhookBase
{
	/// <inheritdoc />
	[JsonPropertyName("webhook_type")]
	public override WebhookType WebhookType => WebhookType.Protect;

	/// <inheritdoc />
	[JsonPropertyName("webhook_code")]
	public override WebhookCode WebhookCode => WebhookCode.ProtectUserEvent;

	/// <summary>
	/// <para>The event ID of the user event that occurred.</para>
	/// </summary>
	[JsonPropertyName("event_id")]
	public string EventId { get; init; } = default!;

	/// <summary>
	/// <para>The type of user event that occurred.</para>
	/// </summary>
	[JsonPropertyName("event_type")]
	public string EventType { get; init; } = default!;

	/// <summary>
	/// <para>The timestamp of the event, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format, e.g. <c>"2017-09-14T14:42:19.350Z"</c></para>
	/// </summary>
	[JsonPropertyName("timestamp")]
	public DateTimeOffset Timestamp { get; init; } = default!;

	/// <summary>
	/// <para>The Plaid User ID.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string? UserId { get; init; } = default!;

}
