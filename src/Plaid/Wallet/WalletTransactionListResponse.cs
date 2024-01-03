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
	/// <para>Cursor used for fetching transactions created before the latest transaction provided in this response</para>
	/// </summary>
	[JsonPropertyName("next_cursor")]
	public string? NextCursor { get; init; } = default!;

}
