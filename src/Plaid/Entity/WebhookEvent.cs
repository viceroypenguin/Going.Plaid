namespace Going.Plaid.Entity;

/// <summary>
/// <para>A webhook event Plaid sent to the calling client.</para>
/// </summary>
public record WebhookEvent
{
	/// <summary>
	/// <para>Stable, opaque, per-webhook ID for deduplication and support reference.</para>
	/// </summary>
	[JsonPropertyName("webhook_message_id")]
	public string WebhookMessageId { get; init; } = default!;

	/// <summary>
	/// <para>The Item ID associated with the webhook, if any.</para>
	/// </summary>
	[JsonPropertyName("item_id")]
	public string? ItemId { get; init; } = default!;

	/// <summary>
	/// <para>The time Plaid sent the webhook.</para>
	/// </summary>
	[JsonPropertyName("sent_time")]
	public DateTimeOffset SentTime { get; init; } = default!;

	/// <summary>
	/// <para>The JSON body Plaid sent to the webhook destination.</para>
	/// </summary>
	[JsonPropertyName("payload")]
	public IReadOnlyDictionary<string, Entity.WebhookEventPayloadObject> Payload { get; init; } = default!;

	/// <summary>
	/// <para>The destination URL Plaid sent the webhook to.</para>
	/// </summary>
	[JsonPropertyName("destination_url")]
	public string DestinationUrl { get; init; } = default!;

	/// <summary>
	/// <para>Latest delivery state for this webhook.</para>
	/// </summary>
	[JsonPropertyName("delivery_status")]
	public Entity.WebhookEventDeliveryStatus DeliveryStatus { get; init; } = default!;

	/// <summary>
	/// <para>The most recent HTTP status code returned by the destination, if any.</para>
	/// </summary>
	[JsonPropertyName("last_http_status_code")]
	public int? LastHttpStatusCode { get; init; } = default!;

	/// <summary>
	/// <para>Number of delivery attempts Plaid has made for this webhook.</para>
	/// </summary>
	[JsonPropertyName("attempt_count")]
	public int AttemptCount { get; init; } = default!;

	/// <summary>
	/// <para>The most recent delivery attempt timestamp. Null if Plaid has not yet attempted delivery.</para>
	/// </summary>
	[JsonPropertyName("last_attempt_time")]
	public DateTimeOffset? LastAttemptTime { get; init; } = default!;

}
