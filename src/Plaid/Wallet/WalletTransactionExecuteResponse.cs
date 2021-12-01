namespace Going.Plaid.Wallet;

/// <summary>
/// <para>WalletTransactionExecuteResponse defines the response schema for <c>/wallet/transaction/execute</c></para>
/// </summary>
public record WalletTransactionExecuteResponse : ResponseBase
{
	/// <summary>
	/// <para>A unique ID identifying the transaction</para>
	/// </summary>
	[JsonPropertyName("transaction_id")]
	public string TransactionId { get; init; } = default!;

	/// <summary>
	/// <para>The status of the transaction.</para>
	/// </summary>
	[JsonPropertyName("status")]
	public Entity.WalletTransactionStatus Status { get; init; } = default!;
}