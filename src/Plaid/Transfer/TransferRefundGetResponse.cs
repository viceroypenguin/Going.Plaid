namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/refund/get</c></para>
/// </summary>
public record TransferRefundGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Represents a refund within the Transfers API.</para>
	/// </summary>
	[JsonPropertyName("refund")]
	public Entity.TransferRefund Refund { get; init; } = default!;
}