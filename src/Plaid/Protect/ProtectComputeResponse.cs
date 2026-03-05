namespace Going.Plaid.Protect;

/// <summary>
/// <para>Response object for /protect/compute</para>
/// </summary>
public record ProtectComputeResponse : ResponseBase
{
	/// <summary>
	/// <para>The trust index score.</para>
	/// </summary>
	[JsonPropertyName("score")]
	public int? Score { get; init; } = default!;

	/// <summary>
	/// <para>The versioned name of the Trust Index model used for scoring.</para>
	/// </summary>
	[JsonPropertyName("model")]
	public string? Model { get; init; } = default!;

	/// <summary>
	/// <para>Event fraud attributes as an arbitrary set of key-value pairs.</para>
	/// </summary>
	[JsonPropertyName("attributes")]
	public Entity.FraudAttributes? Attributes { get; init; } = default!;

}
