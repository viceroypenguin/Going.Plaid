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
	/// <para>The International Bank Account Number (IBAN) for the payer's account. If provided, the end user will be able to send payments only from the specified bank account.</para>
	/// </summary>
	[JsonPropertyName("iban")]
	public string? Iban { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("bacs")]
	public Entity.PaymentInitiationOptionalRestrictionBacs? Bacs { get; set; } = default!;

	/// <summary>
	/// <para>The EMI (E-Money Institution) account that this payment is associated with, if any. This EMI account is used as an intermediary account to enable Plaid to reconcile the settlement of funds for Payment Initiation requests.</para>
	/// </summary>
	[JsonPropertyName("emi_account_id")]
	public string? EmiAccountId { get; set; } = default!;
}