namespace Going.Plaid.Protect;

/// <summary>
/// <para>Response object for /protect/compute</para>
/// </summary>
public record ProtectComputeResponse : ResponseBase
{
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
