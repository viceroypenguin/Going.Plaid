namespace Going.Plaid.Entity;

/// <summary>
/// <para>The counterparty's bank account numbers</para>
/// </summary>
public class WalletTransactionCounterpartyNumbers
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("bacs")]
	public Entity.WalletTransactionCounterpartyBACS Bacs { get; set; } = default!;
}