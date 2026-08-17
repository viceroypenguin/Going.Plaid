namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Use this endpoint to get basic information about a user as it relates to their fraud profile with Protect.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/protect/#protectuserinsightsget" /></remarks>
	public Task<Protect.ProtectUserInsightsGetResponse> ProtectUserInsightsGetAsync(Protect.ProtectUserInsightsGetRequest request) =>
		PostAsync("/protect/user/insights/get", request)
			.ParseResponseAsync<Protect.ProtectUserInsightsGetResponse>();

	/// <summary>
	/// <para>Use this endpoint to create a Protect report to document fraud incidents, investigation outcomes, or other risk events.</para>
	/// <para>This endpoint allows you to report various types of incidents including account takeovers, identity fraud, unauthorized transactions, and other security events.</para>
	/// <para>The reported data helps improve fraud detection models and provides valuable feedback to enhance the overall security of the Plaid network.</para>
	/// <para>Reports can be created for confirmed incidents that have been fully investigated, or for suspected incidents that require further review.</para>
	/// <para>You can associate reports with specific users, sessions, or transactions to provide comprehensive context about the incident.</para>
	/// <para>Each report must include <c>user_id</c>, or an <c>incident_event</c> with at least one supported identifier: <c>link_session_id</c>, <c>idv_session_id</c>, <c>protect_event_id</c>, <c>signal_client_transaction_id</c>, or <c>access_token</c>. Context fields such as <c>internal_reference</c>, <c>time</c>, <c>amount</c>, and <c>bank_account</c> do not satisfy this identifier requirement.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/protect/#protectreportcreate" /></remarks>
	public Task<Protect.ProtectReportCreateResponse> ProtectReportCreateAsync(Protect.ProtectReportCreateRequest request) =>
		PostAsync("/protect/report/create", request)
			.ParseResponseAsync<Protect.ProtectReportCreateResponse>();

	/// <summary>
	/// <para>Use this endpoint to record a cash-advance decision as feedback. A decision is a determination of whether to approve a user's requested advance and on what terms.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/protect/#protectcashadvancedecisioncreate" /></remarks>
	public Task<Protect.ProtectCashAdvanceDecisionCreateResponse> ProtectCashAdvanceDecisionCreateAsync(Protect.ProtectCashAdvanceDecisionCreateRequest request) =>
		PostAsync("/protect/cash_advance/decision/create", request)
			.ParseResponseAsync<Protect.ProtectCashAdvanceDecisionCreateResponse>();

	/// <summary>
	/// <para>Use this endpoint to record a cash-advance repayment as feedback. A repayment is a record paying back all or some of a previously-taken cash-advance.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/protect/#protectcashadvancerepaymentcreate" /></remarks>
	public Task<Protect.ProtectCashAdvanceRepaymentCreateResponse> ProtectCashAdvanceRepaymentCreateAsync(Protect.ProtectCashAdvanceRepaymentCreateRequest request) =>
		PostAsync("/protect/cash_advance/repayment/create", request)
			.ParseResponseAsync<Protect.ProtectCashAdvanceRepaymentCreateResponse>();

	/// <summary>
	/// <para>Compute a Protect Trust Index score for a user. The model selected determines what is scored and what additional fields the response contains. For example, <c>ti-link-session-2.0</c> scores a completed Link session for fraud risk; <c>cash-advance-onboarding-1.0</c> scores repayment risk for a first-time cash advance and additionally populates per-amount-bucket subscores. Cash-advance models require that the user have a Plaid Item with Transactions enabled, or an Assets Report, before scoring.</para>
	/// <para>The endpoint returns HTTP 400 with <c>error_type</c> = <c>INVALID_REQUEST</c> and <c>error_code</c> = <c>FAILED_PRECONDITION</c> when a required precondition is not met: for link-session models, when the Link session has not completed; for cash-advance models, when the user has not successfully linked any Item.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/protect/#protectcompute" /></remarks>
	public Task<Protect.ProtectComputeResponse> ProtectComputeAsync(Protect.ProtectComputeRequest request) =>
		PostAsync("/protect/compute", request)
			.ParseResponseAsync<Protect.ProtectComputeResponse>();

	/// <summary>
	/// <para>Send a new event to enrich user data and optionally get a Trust Index score for the event.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docsnone" /></remarks>
	public Task<Protect.ProtectEventSendResponse> ProtectEventSendAsync(Protect.ProtectEventSendRequest request) =>
		PostAsync("/protect/event/send", request)
			.ParseResponseAsync<Protect.ProtectEventSendResponse>();

	/// <summary>
	/// <para>Get information about a user event including Trust Index score and fraud attributes.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docsnone" /></remarks>
	public Task<Protect.ProtectEventGetResponse> ProtectEventGetAsync(Protect.ProtectEventGetRequest request) =>
		PostAsync("/protect/event/get", request)
			.ParseResponseAsync<Protect.ProtectEventGetResponse>();

}
