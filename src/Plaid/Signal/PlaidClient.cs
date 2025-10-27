namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Use <c>/signal/evaluate</c> to evaluate a planned ACH transaction to get a return risk assessment and additional risk signals.</para>
	/// <para>Before using <c>/signal/evaluate</c>, you must first <a href="https://plaid.com/docs/signal/signal-rules/">create a ruleset</a> in the Dashboard under <a href="https://dashboard.plaid.com/signal/risk-profiles">**Signal->Rules**</a>. </para>
	/// <para><c>/signal/evaluate</c> can be used with either Signal Transaction Scores or the Balance product. Which product is used will be determined by the <c>ruleset_key</c> that you provide. For more details, see <a href="https://plaid.com/docs/signal/signal-rules/">Signal Rules</a>.</para>
	/// <para>Note: This request may have higher latency when using a Balance-only ruleset. This is because Plaid must communicate directly with the institution to request data. Balance-only rulesets may have latency of up to 30 seconds or more; if you encounter errors, you may find it necessary to adjust your timeout period when making requests.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/signal#signalevaluate" /></remarks>
	public Task<Signal.SignalEvaluateResponse> SignalEvaluateAsync(Signal.SignalEvaluateRequest request) =>
		PostAsync("/signal/evaluate", request)
			.ParseResponseAsync<Signal.SignalEvaluateResponse>();

	/// <summary>
	/// <para>Use <c>/signal/schedule</c> to schedule a planned ACH transaction.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docsnone" /></remarks>
	public Task<Signal.SignalScheduleResponse> SignalScheduleAsync(Signal.SignalScheduleRequest request) =>
		PostAsync("/signal/schedule", request)
			.ParseResponseAsync<Signal.SignalScheduleResponse>();

	/// <summary>
	/// <para>After you call <c>/signal/evaluate</c>, Plaid will normally infer the outcome from your Signal Rules. However, if you are not using Signal Rules, if the Signal Rules outcome was <c>REVIEW</c>, or if you take a different action than the one determined by the Signal Rules, you will need to call <c>/signal/decision/report</c>. This helps improve Signal Transaction Score accuracy for your account and is necessary for proper functioning of the rule performance and rule tuning capabilities in the Dashboard. If your effective decision changes after calling <c>/signal/decision/report</c> (for example, you indicated that you accepted a transaction, but later on, your payment processor rejected it, so it was never initiated), call <c>/signal/decision/report</c> again for the transaction to correct Plaid's records.  </para>
	/// <para>If you are using Plaid Transfer as your payment processor, you also do not need to call <c>/signal/decision/report</c>, as Plaid can infer outcomes from your Transfer activity.</para>
	/// <para>If using a Balance-only ruleset, this endpoint will not impact scores (Balance does not use scores), but is necessary to view accurate transaction outcomes and tune rule logic in the Dashboard.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/signal#signaldecisionreport" /></remarks>
	public Task<Signal.SignalDecisionReportResponse> SignalDecisionReportAsync(Signal.SignalDecisionReportRequest request) =>
		PostAsync("/signal/decision/report", request)
			.ParseResponseAsync<Signal.SignalDecisionReportResponse>();

	/// <summary>
	/// <para>Call the <c>/signal/return/report</c> endpoint to report a returned transaction that was previously sent to the <c>/signal/evaluate</c> endpoint. Your feedback will be used by the model to incorporate the latest risk trends into your scores and tune rule logic. If using a Balance-only ruleset, this endpoint will not impact scores (as Balance does not use scores), but is necessary to view accurate transaction outcomes and tune rule logic in the Dashboard.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/signal#signalreturnreport" /></remarks>
	public Task<Signal.SignalReturnReportResponse> SignalReturnReportAsync(Signal.SignalReturnReportRequest request) =>
		PostAsync("/signal/return/report", request)
			.ParseResponseAsync<Signal.SignalReturnReportResponse>();

	/// <summary>
	/// <para>When an Item is not initialized with <c>signal</c>, call <c>/signal/prepare</c> to opt-in that Item to the data collection process used to develop a Signal Transaction Score. This should be done on Items where <c>signal</c> was added in the <c>additional_consented_products</c> array but not in the <c>products</c>, <c>optional_products</c>, or <c>required_if_supported_products</c> array. If <c>/signal/prepare</c> is skipped on an Item that is not initialized with <c>signal</c>, the initial call to <c>/signal/evaluate</c> on that Item will be less accurate, because Plaid will have access to less data for computing the Signal Transaction Score.</para>
	/// <para>If your integration is purely Balance-only, this endpoint will have no effect, as Balance-only rulesets do not calculate a Signal Transaction Score. </para>
	/// <para>If run on an Item that is already initialized with <c>signal</c>, this endpoint will return a 200 response and will not modify the Item.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/signal#signalprepare" /></remarks>
	public Task<Signal.SignalPrepareResponse> SignalPrepareAsync(Signal.SignalPrepareRequest request) =>
		PostAsync("/signal/prepare", request)
			.ParseResponseAsync<Signal.SignalPrepareResponse>();

}
