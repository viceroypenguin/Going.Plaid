namespace Going.Plaid.Beta;

/// <summary>
/// <para>BetaWebhookEventsListRequest defines the request schema for <c>/beta/webhook_events/list</c></para>
/// </summary>
public partial class BetaWebhookEventsListRequest : RequestBase
{
	/// <summary>
	/// <para>Opaque cursor from a prior <c>/beta/webhook_events/list</c> response <c>next_cursor</c>. Use this</para>
	/// <para>on subsequent requests to continue forward. If <c>start_time</c> is also provided,</para>
	/// <para>it is ignored; <c>cursor</c> takes precedence.</para>
	/// </summary>
	[JsonPropertyName("cursor")]
	public string? Cursor { get; set; } = default!;

	/// <summary>
	/// <para>ISO-8601 timestamp. Returns webhook events with <c>sent_time</c> greater than or equal to</para>
	/// <para>this value. When <c>cursor</c> is provided, this value is ignored, even if it has changed</para>
	/// <para>or falls outside the 7-day retention window. Otherwise, it must not be earlier than</para>
	/// <para>the 7-day retention window. Omit both <c>cursor</c> and <c>start_time</c> to begin from the</para>
	/// <para>oldest retained event.</para>
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
	/// <para>Values are case-sensitive and match the webhook types Plaid sends (<c>SCREAMING_SNAKE</c>, for</para>
	/// <para>example <c>ITEM</c> or <c>AUTH</c>).</para>
	/// </summary>
	[JsonPropertyName("webhook_types")]
	public IReadOnlyList<string>? WebhookTypes { get; set; } = default!;

	/// <summary>
	/// <para>Filter by webhook code. Multiple values are OR'd. Combined with other filters using AND.</para>
	/// <para>Values are case-sensitive and match the webhook codes Plaid sends (<c>SCREAMING_SNAKE</c>, for</para>
	/// <para>example <c>ERROR</c>).</para>
	/// </summary>
	[JsonPropertyName("webhook_codes")]
	public IReadOnlyList<string>? WebhookCodes { get; set; } = default!;

	/// <summary>
	/// <para>Filter to specific Items. Multiple values are OR'd. Combined with other filters using AND.</para>
	/// <para>Values are case-sensitive and match the Item IDs Plaid sends.</para>
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
