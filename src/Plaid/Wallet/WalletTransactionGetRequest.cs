namespace Going.Plaid.Wallet;

/// <summary>
/// <para>WalletTransactionGetRequest defines the request schema for <c>/wallet/transaction/get</c></para>
/// </summary>
public partial class WalletTransactionGetRequest : RequestBase
{
	/// <summary>
	/// <para>The ID of the transaction to fetch</para>
	/// </summary>
	[JsonPropertyName("transaction_id")]
	public string TransactionId { get; set; } = default!;
}