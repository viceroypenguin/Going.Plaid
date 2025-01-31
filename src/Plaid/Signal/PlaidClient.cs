namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Use <c>/signal/evaluate</c> to evaluate a planned ACH transaction to get a return risk assessment (such as a risk score and risk tier) and additional risk signals.</para>
	/// <para>In order to obtain a valid score for an ACH transaction, Plaid must have an access token for the account, and the Item must be healthy (receiving product updates) or have recently been in a healthy state. If the transaction does not meet eligibility requirements, an error will be returned corresponding to the underlying cause. If <c>/signal/evaluate</c> is called on the same transaction multiple times within a 24-hour period, cached results may be returned. For more information please refer to the error documentation on <a href="https://plaid.com/docs/errors/item/">Item errors</a> and <a href="https://plaid.com/docs/link/update-mode/">Link in Update Mode</a>.</para>
	/// <para>Note: This request may take some time to complete if Signal is being added to an existing Item. This is because Plaid must communicate directly with the institution when retrieving the data for the first time.</para>
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
	/// <para>After calling <c>/signal/evaluate</c>, call <c>/signal/decision/report</c> to report whether the transaction was initiated.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/signal#signaldecisionreport" /></remarks>
	public Task<Signal.SignalDecisionReportResponse> SignalDecisionReportAsync(Signal.SignalDecisionReportRequest request) =>
		PostAsync("/signal/decision/report", request)
			.ParseResponseAsync<Signal.SignalDecisionReportResponse>();

	/// <summary>
	/// <para>Call the <c>/signal/return/report</c> endpoint to report a returned transaction that was previously sent to the <c>/signal/evaluate</c> endpoint. Your feedback will be used by the model to incorporate the latest risk trend in your portfolio.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/signal#signalreturnreport" /></remarks>
	public Task<Signal.SignalReturnReportResponse> SignalReturnReportAsync(Signal.SignalReturnReportRequest request) =>
		PostAsync("/signal/return/report", request)
			.ParseResponseAsync<Signal.SignalReturnReportResponse>();

	/// <summary>
	/// <para>When an Item is not initialized with Signal, call <c>/signal/prepare</c> to opt-in that Item to the Signal data collection process, developing a Signal score. This should be done on Items where Signal was added in the <c>additional_consented_products</c> array but not in the <c>products</c>, <c>optional_products</c>, or <c>required_if_supported_products</c> array. If <c>/signal/prepare</c> is skipped on an Item that is not initialized with Signal, the initial call to <c>/signal/evaluate</c> on that Item will be less accurate, because Signal will have access to less data for computing the Signal score.</para>
	/// <para>If run on an Item that is already initialized with Signal, this endpoint will return a 200 response and will not modify the Item.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/signal#signalprepare" /></remarks>
	public Task<Signal.SignalPrepareResponse> SignalPrepareAsync(Signal.SignalPrepareRequest request) =>
		PostAsync("/signal/prepare", request)
			.ParseResponseAsync<Signal.SignalPrepareResponse>();

}
