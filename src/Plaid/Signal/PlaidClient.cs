namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Use <c>/signal/evaluate</c> to evaluate a planned ACH transaction to get a return risk assessment (such as a risk score and risk tier) and additional risk signals.</para>
	/// <para>In order to obtain a valid score for an ACH transaction, Plaid must have an access token for the account, and the Item must be healthy (receiving product updates) or have recently been in a healthy state. If the transaction does not meet eligibility requirements, an error will be returned corresponding to the underlying cause. If <c>/signal/evaluate</c> is called on the same transaction multiple times within a 24-hour period, cached results may be returned.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/signal/reference#signalevaluate" /></remarks>
	public Task<Signal.SignalEvaluateResponse> SignalEvaluateAsync(Signal.SignalEvaluateRequest request) =>
		PostAsync("/signal/evaluate", request)
			.ParseResponseAsync<Signal.SignalEvaluateResponse>();

	/// <summary>
	/// <para>After calling <c>/signal/evaluate</c>, call <c>/signal/decision/report</c> to report whether the transaction was initiated. This endpoint will return an <c>INVALID_REQUEST</c> error if called a second time with a different value for <c>initiated</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/signal/reference#signaldecisionreport" /></remarks>
	public Task<Signal.SignalDecisionReportResponse> SignalDecisionReportAsync(Signal.SignalDecisionReportRequest request) =>
		PostAsync("/signal/decision/report", request)
			.ParseResponseAsync<Signal.SignalDecisionReportResponse>();

	/// <summary>
	/// <para>Call the <c>/signal/return/report</c> endpoint to report a returned transaction that was previously sent to the <c>/signal/evaluate</c> endpoint. Your feedback will be used by the model to incorporate the latest risk trend in your portfolio.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/signal/reference#signalreturnreport" /></remarks>
	public Task<Signal.SignalReturnReportResponse> SignalReturnReportAsync(Signal.SignalReturnReportRequest request) =>
		PostAsync("/signal/return/report", request)
			.ParseResponseAsync<Signal.SignalReturnReportResponse>();
}