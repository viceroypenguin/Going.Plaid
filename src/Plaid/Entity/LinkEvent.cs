namespace Going.Plaid.Entity;

/// <summary>
/// <para>An event that occurred while the user was going through Link</para>
/// </summary>
public record LinkEvent
{
	/// <summary>
	/// <para>Event name</para>
	/// </summary>
	[JsonPropertyName("event_name")]
	public string EventName { get; init; } = default!;

	/// <summary>
	/// <para>Timestamp in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format.</para>
	/// </summary>
	[JsonPropertyName("timestamp")]
	public DateTimeOffset Timestamp { get; init; } = default!;

	/// <summary>
	/// <para>UUID that can be used to deduplicate events</para>
	/// </summary>
	[JsonPropertyName("event_id")]
	public string EventId { get; init; } = default!;

	/// <summary>
	/// <para>Metadata about an event that occurred while the user was going through Link</para>
	/// </summary>
	[JsonPropertyName("event_metadata")]
	public Entity.LinkEventMetadata EventMetadata { get; init; } = default!;

}
