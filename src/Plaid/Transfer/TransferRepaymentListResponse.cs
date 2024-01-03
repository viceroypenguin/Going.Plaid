namespace Going.Plaid.Transfer;

/// <summary>
/// <para>Defines the response schema for <c>/transfer/repayments/list</c></para>
/// </summary>
public record TransferRepaymentListResponse : ResponseBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("repayments")]
	public IReadOnlyList<Entity.TransferRepayment> Repayments { get; init; } = default!;

}
