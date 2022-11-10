namespace Going.Plaid.Entity;

/// <summary>
/// <para>Represents a refund within the Transfers API.</para>
/// </summary>
public record TransferRefund
{
	/// <summary>
	/// <para>Plaid’s unique identifier for a refund.</para>
	/// </summary>
	[JsonPropertyName("id")]
	public string Id { get; init; } = default!;

	/// <summary>
	/// <para>The ID of the transfer to refund.</para>
	/// </summary>
	[JsonPropertyName("transfer_id")]
	public string TransferId { get; init; } = default!;

	/// <summary>
	/// <para>The amount of the refund (decimal string with two digits of precision e.g. "10.00").</para>
	/// </summary>
	[JsonPropertyName("amount")]
	public string Amount { get; init; } = default!;

	/// <summary>
	/// <para>The status of the refund.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.TransferRefundStatus Status { get; init; } = default!;

	/// <summary>
	/// <para>The datetime when this refund was created. This will be of the form <c>2006-01-02T15:04:05Z</c></para>
	/// </summary>
	[JsonPropertyName("created")]
	public DateTimeOffset Created { get; init; } = default!;
}