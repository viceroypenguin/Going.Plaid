namespace Going.Plaid.Entity;

/// <summary>
/// <para>The counterparty's bank account numbers</para>
/// </summary>
public class WalletTransactionCounterpartyNumbers
{
	/// <summary>
	/// <para>The account number and sort code of the counterparty's account</para>
	/// </summary>
	[JsonPropertyName("bacs")]
	public Entity.WalletTransactionCounterpartyBACS Bacs { get; set; } = default!;
}