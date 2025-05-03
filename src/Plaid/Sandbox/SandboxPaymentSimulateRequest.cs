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
	/// <para>The webhook url to use for any payment events triggered by the simulated status change.</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string Webhook { get; set; } = default!;

	/// <summary>
	/// <para>The status to set the payment to.</para>
	/// <para>Valid statuses include:</para>
	/// <para>- <c>PAYMENT_STATUS_INITIATED</c></para>
	/// <para>- <c>PAYMENT_STATUS_INSUFFICIENT_FUNDS</c></para>
	/// <para>- <c>PAYMENT_STATUS_FAILED</c></para>
	/// <para>- <c>PAYMENT_STATUS_EXECUTED</c></para>
	/// <para>- <c>PAYMENT_STATUS_SETTLED</c></para>
	/// <para>- <c>PAYMENT_STATUS_CANCELLED</c></para>
	/// <para>- <c>PAYMENT_STATUS_REJECTED</c></para>
	/// </summary>
	[JsonPropertyName("status")]
	public string Status { get; set; } = default!;

}
