namespace Going.Plaid.Sandbox;

/// <summary>
/// <para>SandboxPaymentSimulateRequest defines the request schema for <c>/sandbox/payment/simulate</c></para>
/// </summary>
public partial class SandboxPaymentSimulateRequest : RequestBase
{
	/// <summary>
	/// <para>The ID of the payment to simulate</para>
	/// </summary>
	[JsonPropertyName("payment_id")]
	public string PaymentId { get; set; } = default!;

	/// <summary>
	/// <para>The status to set the payment to. </para>
	/// <para>Valid statuses include:</para>
	/// <para>- PAYMENT_STATUS_INITIATED</para>
	/// <para>- PAYMENT_STATUS_INSUFFICIENT_FUNDS</para>
	/// <para>- PAYMENT_STATUS_FAILED</para>
	/// <para>- PAYMENT_STATUS_EXECUTED</para>
	/// <para>- PAYMENT_STATUS_SETTLED</para>
	/// <para>- PAYMENT_STATUS_CANCELLED</para>
	/// <para>- PAYMENT_STATUS_REJECTED</para>
	/// </summary>
	[JsonPropertyName("status")]
	public string Status { get; set; } = default!;

}
