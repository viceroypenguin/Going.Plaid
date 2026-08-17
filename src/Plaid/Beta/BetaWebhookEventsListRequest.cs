namespace Going.Plaid.Beta;

/// <summary>
/// <para>BetaWebhookEventsListRequest defines the request schema for <c>/beta/webhook_events/list</c></para>
/// </summary>
public partial class BetaWebhookEventsListRequest : RequestBase
{
	/// <summary>
	/// <para>Opaque cursor from a prior <c>/beta/webhook_events/list</c> response <c>next_cursor</c>. Use this</para>
	/// <para>on subsequent requests to continue forward. Mutually exclusive with <c>start_time</c>.</para>
	/// </summary>
	[JsonPropertyName("cursor")]
	public string? Cursor { get; set; } = default!;

	/// <summary>
	/// <para>ISO-8601 timestamp. Returns webhook events with <c>sent_time</c> greater than or equal to</para>
	/// <para>this value. Must fall within the last 7 days (the retention window). Mutually exclusive</para>
	/// <para>with <c>cursor</c>. Omit to begin from the oldest retained event.</para>
	/// </summary>
	[JsonPropertyName("start_time")]
	public DateTimeOffset? StartTime { get; set; } = default!;

	/// <summary>
	/// <para>Page size. Default 100, maximum 100.</para>
	/// </summary>
	[JsonPropertyName("count")]
	public int? Count { get; set; } = default!;

	/// <summary>
	/// <para>Filter by webhook type. Multiple values are OR'd. Combined with other filters using AND.</para>
	/// </summary>
	[JsonPropertyName("webhook_types")]
	public IReadOnlyList<string>? WebhookTypes { get; set; } = default!;

	/// <summary>
	/// <para>Filter by webhook code. Multiple values are OR'd. Combined with other filters using AND.</para>
	/// </summary>
	[JsonPropertyName("webhook_codes")]
	public IReadOnlyList<string>? WebhookCodes { get; set; } = default!;

	/// <summary>
	/// <para>Filter to specific Items. Multiple values are OR'd. Combined with other filters using AND.</para>
	/// </summary>
	[JsonPropertyName("item_ids")]
	public IReadOnlyList<string>? ItemIds { get; set; } = default!;

	/// <summary>
	/// <para>Filter by delivery status. Returns webhook events whose latest delivery state matches</para>
	/// <para>any of the supplied values. Combined with other filters using AND.</para>
	/// </summary>
	[JsonPropertyName("delivery_statuses")]
	public IReadOnlyList<Entity.WebhookEventDeliveryStatus>? DeliveryStatuses { get; set; } = default!;

}
