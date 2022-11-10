namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/refund/create</c></para>
/// </summary>
public record TransferRefundCreateResponse : ResponseBase
{
	/// <summary>
	/// <para>Represents a refund within the Transfers API.</para>
	/// </summary>
	[JsonPropertyName("refund")]
	public Entity.TransferRefund Refund { get; init; } = default!;
}