namespace Going.Plaid.BankTransfer;

/// <summary>
/// <para>BankTransferSweepListResponse defines the response schema for <c>/bank_transfer/sweep/list</c></para>
/// </summary>
public record BankTransferSweepListResponse : ResponseBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("sweeps")]
	public IReadOnlyList<Entity.BankTransferSweep> Sweeps { get; init; } = default!;
}