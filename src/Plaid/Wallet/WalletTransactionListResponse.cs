namespace Going.Plaid.Wallet;

/// <summary>
/// <para>WalletTransactionListResponse defines the response schema for <c>/wallet/transaction/list</c></para>
/// </summary>
public record WalletTransactionListResponse : ResponseBase
{
	/// <summary>
	/// <para>An array of transactions of an e-wallet, associated with the given <c>wallet_id</c></para>
	/// </summary>
	[JsonPropertyName("transactions")]
	public IReadOnlyList<Entity.WalletTransaction> Transactions { get; init; } = default!;

	/// <summary>
	/// <para>The value that, when used as the optional <c>cursor</c> parameter to <c>/wallet/transaction/list</c>, will return the corresponding transaction as its first entry.</para>
	/// </summary>
	[JsonPropertyName("next_cursor")]
	public string? NextCursor { get; init; } = default!;

}
