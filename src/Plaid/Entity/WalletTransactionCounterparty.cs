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

	/// <summary>
	/// <para>The optional address of the payment recipient's bank account. Required by most institutions outside of the UK.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.PaymentInitiationAddress? Address { get; set; } = default!;

	/// <summary>
	/// <para>The counterparty's birthdate, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> (YYYY-MM-DD) format.</para>
	/// </summary>
	[JsonPropertyName("date_of_birth")]
	public DateOnly? DateOfBirth { get; set; } = default!;
}