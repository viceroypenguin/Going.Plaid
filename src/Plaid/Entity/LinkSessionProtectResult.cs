namespace Going.Plaid.Entity;

/// <summary>
/// <para>Plaid Protect details from the Link session</para>
/// </summary>
public record LinkSessionProtectResult
{
	/// <summary>
	/// <para>The Plaid Protect event ID representing the completion of the link session.</para>
	/// </summary>
	[JsonPropertyName("event_id")]
	public string EventId { get; init; } = default!;

	/// <summary>
	/// <para>Represents a calculate Trust Index Score.</para>
	/// </summary>
	[JsonPropertyName("trust_index")]
	public Entity.TrustIndex? TrustIndex { get; init; } = default!;

	/// <summary>
	/// <para>Contains attributes used during a trust index calculation.</para>
	/// </summary>
	[JsonPropertyName("fraud_attributes")]
	public Entity.LinkSessionProtectResultFraudAttributes? FraudAttributes { get; init; } = default!;

}
