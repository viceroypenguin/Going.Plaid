namespace Going.Plaid.Entity;

/// <summary>
/// <para>(Deprecated) Additional payment consent options. Please use <c>payer_details</c> to specify the account.</para>
/// </summary>
public class ExternalPaymentInitiationConsentOptions
{
	/// <summary>
	/// <para>When <c>true</c>, Plaid will attempt to request refund details from the payee's financial institution.  Support varies between financial institutions and will not always be available.  If refund details could be retrieved, they will be available in the <c>/payment_initiation/payment/get</c> response.</para>
	/// </summary>
	[JsonPropertyName("request_refund_details")]
	public bool? RequestRefundDetails { get; set; } = default!;

	/// <summary>
	/// <para>The International Bank Account Number (IBAN) for the payer's account. Where possible, the end user will be able to set up payment consent using only the specified bank account if provided.</para>
	/// </summary>
	[JsonPropertyName("iban")]
	public string? Iban { get; set; } = default!;

	/// <summary>
	/// <para>An optional object used to restrict the accounts used for payments. If provided, the end user will be able to send payments only from the specified bank account.</para>
	/// </summary>
	[JsonPropertyName("bacs")]
	public Entity.PaymentInitiationOptionalRestrictionBacs? Bacs { get; set; } = default!;

}
