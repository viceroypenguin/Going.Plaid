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
	/// <para>The counterparty's bank account numbers. Exactly one of IBAN or Bacs data is required.</para>
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

	/// <summary>
	/// <para>Whether the counterparty is a personal or a business account holder. Payee verification schemes match a different set of identifiers for a natural person and a legal entity.</para>
	/// <para><c>personal</c>: the counterparty is an individual.</para>
	/// <para><c>business</c>: the counterparty is a company.</para>
	/// <para>If this is omitted, a payee verification check on a GBP payout returns <c>CHECK_NOT_POSSIBLE</c>. Accepted on <c>/wallet/transaction/execute</c> and not returned on read endpoints.</para>
	/// </summary>
	[JsonPropertyName("holder_category")]
	public Entity.WalletTransactionCounterpartyHolderCategory? HolderCategory { get; set; } = default!;

	/// <summary>
	/// <para>Set to <c>true</c> if you have already verified that this counterparty owns the account, either through your own checks or through Plaid Auth or Identity. Plaid then skips its payee verification check.</para>
	/// <para>Whether Plaid runs a check is determined by Plaid configuration, so this field can only suppress a check and never request one. Only applies to GBP payouts.</para>
	/// <para>Accepted on <c>/wallet/transaction/execute</c> and not returned on read endpoints.</para>
	/// </summary>
	[JsonPropertyName("is_verified")]
	public bool? IsVerified { get; set; } = default!;

}
