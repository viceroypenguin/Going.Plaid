namespace Going.Plaid.Entity;

/// <summary>
/// <para>Additional payment consent options</para>
/// </summary>
public class ExternalPaymentInitiationConsentOptions
{
	/// <summary>
	/// <para>The EMI (E-Money Institution) wallet that this payment consent is associated with, if any. This wallet is used as an intermediary account to enable Plaid to reconcile the settlement of funds for Payment Initiation requests.</para>
	/// </summary>
	[JsonPropertyName("wallet_id")]
	public string? WalletId { get; set; } = default!;

	/// <summary>
	/// <para>When <c>true</c>, Plaid will attempt to request refund details from the payee's financial institution.  Support varies between financial institutions and will not always be available.  If refund details could be retrieved, they will be available in the <c>/payment_initiation/payment/get</c> response.</para>
	/// </summary>
	[JsonPropertyName("request_refund_details")]
	public bool? RequestRefundDetails { get; set; } = default!;
}