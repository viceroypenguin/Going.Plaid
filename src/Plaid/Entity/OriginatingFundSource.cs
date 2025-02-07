namespace Going.Plaid.Entity;

/// <summary>
/// <para>The original source of the funds. This field is required by local regulation for certain businesses (e.g. money remittance) to send payouts to recipients in the EU and UK.</para>
/// </summary>
public class OriginatingFundSource
{
	/// <summary>
	/// <para>The full name associated with the source of the funds.</para>
	/// </summary>
	[JsonPropertyName("full_name")]
	public string FullName { get; set; } = default!;

	/// <summary>
	/// <para>The optional address of the payment recipient's bank account. Required by most institutions outside of the UK.</para>
	/// </summary>
	[JsonPropertyName("address")]
	public Entity.PaymentInitiationAddress? Address { get; set; } = default!;

	/// <summary>
	/// <para>The account number from which the funds are sourced.</para>
	/// </summary>
	[JsonPropertyName("account_number")]
	public string AccountNumber { get; set; } = default!;

	/// <summary>
	/// <para>The Business Identifier Code, also known as SWIFT code, for this bank account.</para>
	/// </summary>
	[JsonPropertyName("bic")]
	public string Bic { get; set; } = default!;

}
