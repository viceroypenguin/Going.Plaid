namespace Going.Plaid.BankTransfer;

/// <summary>
/// <para>BankTransferListResponse defines the response schema for <c>/bank_transfer/list</c></para>
/// </summary>
public record BankTransferListResponse : ResponseBase
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("bank_transfers")]
	public IReadOnlyList<Entity.BankTransfer> BankTransfers { get; init; } = default!;
}