namespace Going.Plaid.Entity;

/// <summary>
/// <para>International Bank Account Number for a Wallet Transaction</para>
/// </summary>
public class WalletTransactionCounterpartyInternational
{
	/// <summary>
	/// <para>International Bank Account Number (IBAN).</para>
	/// </summary>
	[JsonPropertyName("iban")]
	public string Iban { get; set; } = default!;
}