namespace Going.Plaid.Entity;

/// <summary>
/// <para>The counterparty's bank account numbers. Exactly one of IBAN or BACS data is required.</para>
/// </summary>
public class PaymentInitiationConsentPayerNumbers
{
	/// <summary>
	/// <para>An optional object used to restrict the accounts used for payments. If provided, the end user will be able to send payments only from the specified bank account.</para>
	/// </summary>
	[JsonPropertyName("bacs")]
	public Entity.PaymentInitiationOptionalRestrictionBacs? Bacs { get; set; } = default!;

	/// <summary>
	/// <para>International Bank Account Number (IBAN).</para>
	/// </summary>
	[JsonPropertyName("iban")]
	public string? Iban { get; set; } = default!;

}
