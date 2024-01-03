namespace Going.Plaid.Entity;

/// <summary>
/// <para>Additional payment options</para>
/// </summary>
public class PaymentOptions
{
	/// <summary>
	/// <para>When <c>true</c>, Plaid will attempt to request refund details from the payee's financial institution.  Support varies between financial institutions and will not always be available.  If refund details could be retrieved, they will be available in the <c>/payment_initiation/payment/get</c> response.</para>
	/// </summary>
	[JsonPropertyName("request_refund_details")]
	public bool? RequestRefundDetails { get; set; } = default!;

	/// <summary>
	/// <para>The International Bank Account Number (IBAN) for the payer's account. Where possible, the end user will be able to send payments only from the specified bank account if provided.</para>
	/// </summary>
	[JsonPropertyName("iban")]
	public string? Iban { get; set; } = default!;

	/// <summary>
	/// <para>An optional object used to restrict the accounts used for payments. If provided, the end user will be able to send payments only from the specified bank account.</para>
	/// </summary>
	[JsonPropertyName("bacs")]
	public Entity.PaymentInitiationOptionalRestrictionBacs? Bacs { get; set; } = default!;

	/// <summary>
	/// <para>Payment scheme. If not specified - the default in the region will be used (e.g. <c>SEPA_CREDIT_TRANSFER</c> for EU). Using unsupported values will result in a failed payment.</para>
	/// </summary>
	[JsonPropertyName("scheme")]
	public Entity.PaymentScheme? Scheme { get; set; } = default!;

}
