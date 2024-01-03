namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/repayments/return/list</c></para>
/// </summary>
public record TransferRepaymentReturnListResponse : ResponseBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("repayment_returns")]
	public IReadOnlyList<Entity.TransferRepaymentReturn> RepaymentReturns { get; init; } = default!;

}
