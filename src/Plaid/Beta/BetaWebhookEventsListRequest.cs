namespace Going.Plaid.Beta;

/// <summary>
/// <para>BetaWebhookEventsListRequest defines the request schema for <c>/beta/webhook_events/list</c></para>
/// </summary>
public partial class BetaWebhookEventsListRequest : RequestBase
{
	/// <summary>
	/// <para>The <c>next_cursor</c> from a previous <c>/beta/webhook_events/list</c> response. Omit on your first request. If provided, <c>start_time</c> is ignored.</para>
	/// </summary>
	[JsonPropertyName("cursor")]
	public string? Cursor { get; set; } = default!;

	/// <summary>
	/// <para>Return events sent at or after this time, in ISO 8601 format. Must be within the last 7 days. Ignored if <c>cursor</c> is provided. If you omit both <c>cursor</c> and <c>start_time</c>, results start with the oldest retained event.</para>
	/// </summary>
	[JsonPropertyName("start_time")]
	public DateTimeOffset? StartTime { get; set; } = default!;

	/// <summary>
	/// <para>The maximum number of webhook events to return. Fewer events may be returned even when more are available; use <c>has_more</c> to determine whether to request another page.</para>
	/// </summary>
	[JsonPropertyName("count")]
	public int? Count { get; set; } = default!;

	/// <summary>
	/// <para>Return only events with these webhook types, for example <c>ITEM</c>. Case-sensitive.</para>
	/// </summary>
	[JsonPropertyName("webhook_types")]
	public IReadOnlyList<string>? WebhookTypes { get; set; } = default!;

	/// <summary>
	/// <para>Return only events with these webhook codes, for example <c>ERROR</c>. Case-sensitive.</para>
	/// </summary>
	[JsonPropertyName("webhook_codes")]
	public IReadOnlyList<string>? WebhookCodes { get; set; } = default!;

	/// <summary>
	/// <para>Return only events for these Items.</para>
	/// </summary>
	[JsonPropertyName("item_ids")]
	public IReadOnlyList<string>? ItemIds { get; set; } = default!;

	/// <summary>
	/// <para>Return only events with these delivery statuses.</para>
	/// </summary>
	[JsonPropertyName("delivery_statuses")]
	public IReadOnlyList<Entity.WebhookEventDeliveryStatus>? DeliveryStatuses { get; set; } = default!;

}
