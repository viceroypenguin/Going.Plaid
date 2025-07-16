namespace Going.Plaid.Wallet;

/// <summary>
/// <para>WalletTransactionListRequest defines the request schema for <c>/wallet/transaction/list</c></para>
/// </summary>
public partial class WalletTransactionListRequest : RequestBase
{
	/// <summary>
	/// <para>The ID of the e-wallet to fetch transactions from</para>
	/// </summary>
	[JsonPropertyName("wallet_id")]
	public string WalletId { get; set; } = default!;

	/// <summary>
	/// <para>A value representing the latest transaction to be included in the response. Set this from <c>next_cursor</c> received in the previous <c>/wallet/transaction/list</c> request. If provided, the response will only contain that transaction and transactions created before it. If omitted, the response will contain transactions starting from the most recent, and in descending order by the <c>created_at</c> time.</para>
	/// </summary>
	[JsonPropertyName("cursor")]
	public string? Cursor { get; set; } = default!;

	/// <summary>
	/// <para>The number of transactions to fetch</para>
	/// </summary>
	[JsonPropertyName("count")]
	public int? Count { get; set; } = default!;

	/// <summary>
	/// <para>Additional wallet transaction options</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.WalletTransactionListRequestOptions? Options { get; set; } = default!;

}
