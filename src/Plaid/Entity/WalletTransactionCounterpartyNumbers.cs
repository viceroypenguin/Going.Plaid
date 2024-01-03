namespace Going.Plaid.Entity;

/// <summary>
/// <para>The counterparty's bank account numbers. Exactly one of IBAN or BACS data is required.</para>
/// </summary>
public class WalletTransactionCounterpartyNumbers
{
	/// <summary>
	/// <para>The account number and sort code of the counterparty's account</para>
	/// </summary>
	[JsonPropertyName("bacs")]
	public Entity.WalletTransactionCounterpartyBACS? Bacs { get; set; } = default!;

	/// <summary>
	/// <para>International Bank Account Number for a Wallet Transaction</para>
	/// </summary>
	[JsonPropertyName("international")]
	public Entity.WalletTransactionCounterpartyInternational? International { get; set; } = default!;

}
