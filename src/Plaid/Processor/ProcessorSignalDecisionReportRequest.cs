namespace Going.Plaid.Processor;

/// <summary>
/// <para>ProcessorSignalDecisionReportRequest defines the request schema for <c>/processor/signal/decision/report</c></para>
/// </summary>
public partial class ProcessorSignalDecisionReportRequest : RequestBase
{
	/// <summary>
	/// <para>The processor token obtained from the Plaid integration partner. Processor tokens are in the format: <c>processor-&lt;environment&gt;-&lt;identifier&gt;</c></para>
	/// </summary>
	[JsonPropertyName("processor_token")]
	public string ProcessorToken { get; set; } = default!;

	/// <summary>
	/// <para>Must be the same as the <c>client_transaction_id</c> supplied when calling <c>/signal/evaluate</c></para>
	/// </summary>
	[JsonPropertyName("client_transaction_id")]
	public string ClientTransactionId { get; set; } = default!;

	/// <summary>
	/// <para><c>true</c> if the ACH transaction was initiated, <c>false</c> otherwise.</para>
	/// <para>This field must be returned as a boolean. If formatted incorrectly, this will result in an <a href="https://plaid.com/docs/errors/invalid-request/#invalid_field"><c>INVALID_FIELD</c></a> error.</para>
	/// </summary>
	[JsonPropertyName("initiated")]
	public bool Initiated { get; set; } = default!;

	/// <summary>
	/// <para>The actual number of days (hold time) since the ACH debit transaction that you wait before making funds available to your customers. The holding time could affect the ACH return rate.</para>
	/// <para>For example, use 0 if you make funds available to your customers instantly or the same day following the debit transaction, or 1 if you make funds available the next day following the debit initialization.</para>
	/// </summary>
	[JsonPropertyName("days_funds_on_hold")]
	public int? DaysFundsOnHold { get; set; } = default!;

	/// <summary>
	/// <para>The payment decision from the risk assessment.</para>
	/// </summary>
	[JsonPropertyName("decision_outcome")]
	public Entity.SignalDecisionOutcome? DecisionOutcome { get; set; } = default!;

	/// <summary>
	/// <para>The payment method to complete the transaction after the risk assessment. It may be different from the default payment method.</para>
	/// </summary>
	[JsonPropertyName("payment_method")]
	public Entity.SignalPaymentMethod? PaymentMethod { get; set; } = default!;

	/// <summary>
	/// <para>The amount (in USD) made available to your customers instantly following the debit transaction. It could be a partial amount of the requested transaction (example: 102.05).</para>
	/// </summary>
	[JsonPropertyName("amount_instantly_available")]
	public decimal? AmountInstantlyAvailable { get; set; } = default!;

}
