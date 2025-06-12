namespace Going.Plaid.Protect;

/// <summary>
/// <para>Response object for /protect/event/send</para>
/// </summary>
public record ProtectEventSendResponse : ResponseBase
{
	/// <summary>
	/// <para>The id of the recorded event.</para>
	/// </summary>
	[JsonPropertyName("event_id")]
	public string EventId { get; init; } = default!;

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
