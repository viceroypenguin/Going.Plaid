namespace Going.Plaid.Signal;

/// <summary>
/// <para>SignalDecisionReportRequest defines the request schema for <c>/signal/decision/report</c></para>
/// </summary>
public partial class SignalDecisionReportRequest : RequestBase
{
	/// <summary>
	/// <para>Must be the same as the <c>client_transaction_id</c> supplied when calling <c>/signal/evaluate</c></para>
	/// </summary>
	[JsonPropertyName("client_transaction_id")]
	public string ClientTransactionId { get; set; } = default!;

	/// <summary>
	/// <para><c>true</c> if the ACH transaction was initiated, <c>false</c> otherwise.</para>
	/// </summary>
	[JsonPropertyName("initiated")]
	public bool Initiated { get; set; } = default!;

	/// <summary>
	/// <para>The actual number of days (hold time) since the ACH debit transaction that you wait before making funds available to your customers. The holding time could affect the ACH return rate. For example, use 0 if you make funds available to your customers instantly or the same day following the debit transaction, or 1 if you make funds available the next day following the debit initialization.</para>
	/// </summary>
	[JsonPropertyName("days_funds_on_hold")]
	public int? DaysFundsOnHold { get; set; } = default!;
}