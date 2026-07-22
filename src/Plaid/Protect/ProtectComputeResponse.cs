namespace Going.Plaid.Protect;

/// <summary>
/// <para>Response object for /protect/compute</para>
/// </summary>
public record ProtectComputeResponse : ResponseBase
{
	/// <summary>
	/// <para>The Trust Index score, on a 0-100 scale where higher values indicate lower risk.</para>
	/// </summary>
	[JsonPropertyName("score")]
	public int? Score { get; init; } = default!;

	/// <summary>
	/// <para>The versioned name of the Trust Index model used for scoring.</para>
	/// </summary>
	[JsonPropertyName("model")]
	public string? Model { get; init; } = default!;

	/// <summary>
	/// <para>Event fraud attributes as an arbitrary set of key-value pairs. The set of attributes returned varies by model.</para>
	/// </summary>
	[JsonPropertyName("attributes")]
	public Entity.FraudAttributes? Attributes { get; init; } = default!;

	/// <summary>
	/// <para>Per-bucket subscores returned alongside the overall Trust Index score. For cash-advance models, each key maps to an amount-bucket subscore (0-100); higher values indicate lower fraud risk. Only buckets that were scored are included in the response.</para>
	/// </summary>
	[JsonPropertyName("subscores")]
	public Entity.ProtectComputeSubscores? Subscores { get; init; } = default!;

	/// <summary>
	/// <para>The timestamp when the Trust Index score and fraud attributes were computed, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format, e.g. <c>"2017-09-14T14:42:19.350Z"</c></para>
	/// </summary>
	[JsonPropertyName("timestamp")]
	public DateTimeOffset? Timestamp { get; init; } = default!;

}
