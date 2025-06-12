namespace Going.Plaid.Protect;

/// <summary>
/// <para>Response object for /protect/event/get</para>
/// </summary>
public record ProtectEventGetResponse : ResponseBase
{
	/// <summary>
	/// <para>The event ID.</para>
	/// </summary>
	[JsonPropertyName("event_id")]
	public string EventId { get; init; } = default!;

	/// <summary>
	/// <para>The timestamp of the event, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format, e.g. <c>"2017-09-14T14:42:19.350Z"</c></para>
	/// </summary>
	[JsonPropertyName("timestamp")]
	public DateTimeOffset Timestamp { get; init; } = default!;

	/// <summary>
	/// <para>Represents a calculate Trust Index Score.</para>
	/// </summary>
	[JsonPropertyName("trust_index")]
	public Entity.TrustIndex? TrustIndex { get; init; } = default!;

	/// <summary>
	/// <para>Event fraud attributes as an arbitrary set of key-value pairs.</para>
	/// </summary>
	[JsonPropertyName("fraud_attributes")]
	public Entity.FraudAttributes? FraudAttributes { get; init; } = default!;

}
