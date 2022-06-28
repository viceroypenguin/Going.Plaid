namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing the e-wallet transaction's counterparty</para>
/// </summary>
public class WalletTransactionCounterparty
{
	/// <summary>
	/// <para>The name of the counterparty</para>
	/// </summary>
	[JsonPropertyName("name")]
	public string Name { get; set; } = default!;

	/// <summary>
	/// <para>The counterparty's bank account numbers. Exactly one of IBAN or BACS data is required.</para>
	/// </summary>
	[JsonPropertyName("numbers")]
	public Entity.WalletTransactionCounterpartyNumbers Numbers { get; set; } = default!;
}