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
	/// <para>The EMI (E-Money Institution) wallet that this payment is associated with, if any. This wallet is used as an intermediary account to enable Plaid to reconcile the settlement of funds for Payment Initiation requests.</para>
	/// </summary>
	[JsonPropertyName("wallet_id")]
	public string? WalletId { get; set; } = default!;

	/// <summary>
	/// <para>Payment scheme. If not specified - the default in the region will be used (e.g. <c>SEPA_CREDIT_TRANSFER</c> for EU). Using unsupported values will result in a failed payment.</para>
	/// </summary>
	[JsonPropertyName("scheme")]
	public Entity.PaymentScheme? Scheme { get; set; } = default!;

	/// <summary>
	/// <para>When <c>true</c>, Plaid will attempt to automatically downgrade payment <c>scheme</c> (e.g. <c>SEPA_CREDIT_TRANSFER_INSTANT</c> to <c>SEPA_CREDIT_TRANSFER</c>) when the requested scheme is not supported by the bank.</para>
	/// </summary>
	[JsonPropertyName("scheme_automatic_downgrade")]
	public bool? SchemeAutomaticDowngrade { get; set; } = default!;
}