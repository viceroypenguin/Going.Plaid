namespace Going.Plaid.Entity;

/// <summary>
/// <para>The information about a previously submitted valid dispute statement by the consumer</para>
/// </summary>
public record ConsumerDispute
{
	/// <summary>
	/// <para>(Deprecated) A unique identifier (UUID) of the consumer dispute that can be used for troubleshooting</para>
	/// </summary>
	[JsonPropertyName("consumer_dispute_id")]
	[Obsolete]
	public string ConsumerDisputeId { get; init; } = default!;

	/// <summary>
	/// <para>Date of the disputed field (e.g. transaction date), in an ISO 8601 format (YYYY-MM-DD)</para>
	/// </summary>
	[JsonPropertyName("dispute_field_create_date")]
	public DateOnly DisputeFieldCreateDate { get; init; } = default!;

	/// <summary>
	/// <para>Type of data being disputed by the consumer</para>
	/// </summary>
	[JsonPropertyName("category")]
	public Entity.ConsumerReportCategory Category { get; init; } = default!;

	/// <summary>
	/// <para>Text content of dispute</para>
	/// </summary>
	[JsonPropertyName("statement")]
	public string Statement { get; init; } = default!;

}
