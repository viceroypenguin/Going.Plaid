namespace Going.Plaid.Beta;

/// <summary>
/// <para>BetaWebhookEventsListRequest defines the request schema for <c>/beta/webhook_events/list</c></para>
/// </summary>
public partial class BetaWebhookEventsListRequest : RequestBase
{
	/// <summary>
	/// <para>Opaque cursor from a prior <c>/beta/webhook_events/list</c> response <c>next_cursor</c>. Use this</para>
	/// <para>on subsequent requests to continue forward. Mutually exclusive with <c>start_time</c>: sending</para>
	/// <para>both returns <c>INVALID_FIELD</c>. Callers should send only one.</para>
	/// </summary>
	[JsonPropertyName("cursor")]
	public string? Cursor { get; set; } = default!;

	/// <summary>
	/// <para>ISO-8601 timestamp. Returns webhook events with <c>sent_time</c> greater than or equal to</para>
	/// <para>this value. Must not be earlier than the 7-day retention window. Mutually exclusive with</para>
	/// <para><c>cursor</c>: sending both returns <c>INVALID_FIELD</c>. Omit to begin from the oldest retained</para>
	/// <para>event. Callers should send only one of <c>cursor</c> or <c>start_time</c>.</para>
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
