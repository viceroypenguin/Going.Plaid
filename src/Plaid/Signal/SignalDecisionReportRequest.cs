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
}