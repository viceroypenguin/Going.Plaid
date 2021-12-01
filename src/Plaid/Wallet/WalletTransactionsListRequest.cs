namespace Going.Plaid.Wallet;

/// <summary>
/// <para>WalletTransactionsListRequest defines the request schema for <c>/wallet/transactions/list</c></para>
/// </summary>
public partial class WalletTransactionsListRequest : RequestBase
{
	/// <summary>
	/// <para>The ID of the e-wallet to fetch transactions from</para>
	/// </summary>
	[JsonPropertyName("wallet_id")]
	public string WalletId { get; set; } = default!;

	/// <summary>
	/// <para>A base64 value representing the latest transaction that has already been requested. Set this to <c>next_cursor</c> received from the previous <c>/wallet/transactions/list</c> request. If provided, the response will only contain transactions created before that transaction. If omitted, the response will contain transactions starting from the most recent, and in descending order by the <c>created_at</c> time.</para>
	/// </summary>
	[JsonPropertyName("cursor")]
	public string Cursor { get; set; } = default!;

	/// <summary>
	/// <para>The number of transactions to fetch</para>
	/// </summary>
	[JsonPropertyName("count")]
	public int Count { get; set; } = default!;
}