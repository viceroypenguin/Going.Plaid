namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/transfer/get</c> endpoint fetches information about the transfer corresponding to the given <c>transfer_id</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transferget" /></remarks>
	public Task<Transfer.TransferGetResponse> TransferGetAsync(Transfer.TransferGetRequest request) =>
		PostAsync("/transfer/get", request)
			.ParseResponseAsync<Transfer.TransferGetResponse>();

	/// <summary>
	/// <para>The <c>/transfer/recurring/get</c> fetches information about the recurring transfer corresponding to the given <c>recurring_transfer_id</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transferrecurringget" /></remarks>
	public Task<Transfer.TransferRecurringGetResponse> TransferRecurringGetAsync(Transfer.TransferRecurringGetRequest request) =>
		PostAsync("/transfer/recurring/get", request)
			.ParseResponseAsync<Transfer.TransferRecurringGetResponse>();

	/// <summary>
	/// <para>Use the <c>/transfer/authorization/create</c> endpoint to determine transfer failure risk.</para>
	/// <para>In Plaid's Sandbox environment the decisions will be returned as follows:</para>
	/// <para>  - To approve a transfer with null rationale code, make an authorization request with an <c>amount</c> less than the available balance in the account.</para>
	/// <para>  - To approve a transfer with the rationale code <c>MANUALLY_VERIFIED_ITEM</c>, create an Item in Link through the <a href="https://plaid.com/docs/auth/coverage/testing/#testing-same-day-micro-deposits">Same Day Micro-deposits flow</a>.</para>
	/// <para>  - To approve a transfer with the rationale code <c>ITEM_LOGIN_REQUIRED</c>, <a href="https://plaid.com/docs/sandbox/#item_login_required">reset the login for an Item</a>.</para>
	/// <para>  - To decline a transfer with the rationale code <c>NSF</c>, the available balance on the account must be less than the authorization <c>amount</c>. See <a href="https://plaid.com/docs/sandbox/user-custom/">Create Sandbox test data</a> for details on how to customize data in Sandbox.</para>
	/// <para>  - To decline a transfer with the rationale code <c>RISK</c>, the available balance on the account must be exactly $0. See <a href="https://plaid.com/docs/sandbox/user-custom/">Create Sandbox test data</a> for details on how to customize data in Sandbox.</para>
	/// <para>The fields <c>device.ip_address</c> and <c>device.user_agent</c> are required for all sessions where the end-user is present. For example, when a user is authorizing a one-time payment from their device.</para>
	/// <para>For <a href="https://www.plaid.com/docs//transfer/guarantee/">Guarantee</a>, the following fields are required : <c>idempotency_key</c>, <c>user.phone_number</c> (optional if <c>email_address</c> provided), <c>user.email_address</c> (optional if <c>phone_number</c> provided), <c>device.ip_address</c>, <c>device.user_agent</c>, and <c>user_present</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transferauthorizationcreate" /></remarks>
	public Task<Transfer.TransferAuthorizationCreateResponse> TransferAuthorizationCreateAsync(Transfer.TransferAuthorizationCreateRequest request) =>
		PostAsync("/transfer/authorization/create", request)
			.ParseResponseAsync<Transfer.TransferAuthorizationCreateResponse>();

	/// <summary>
	/// <para>Use the <c>/transfer/balance/get</c> endpoint to view a balance held with Plaid.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transferbalanceget" /></remarks>
	public Task<Transfer.TransferBalanceGetResponse> TransferBalanceGetAsync(Transfer.TransferBalanceGetRequest request) =>
		PostAsync("/transfer/balance/get", request)
			.ParseResponseAsync<Transfer.TransferBalanceGetResponse>();

	/// <summary>
	/// <para>Use the <c>/transfer/capabilities/get</c> endpoint to determine the RTP eligibility information of a transfer.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transfercapabilitiesget" /></remarks>
	public Task<Transfer.TransferCapabilitiesGetResponse> TransferCapabilitiesGetAsync(Transfer.TransferCapabilitiesGetRequest request) =>
		PostAsync("/transfer/capabilities/get", request)
			.ParseResponseAsync<Transfer.TransferCapabilitiesGetResponse>();

	/// <summary>
	/// <para>Use the <c>/transfer/configuration/get</c> endpoint to view your transfer product configurations.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transferconfigurationget" /></remarks>
	public Task<Transfer.TransferConfigurationGetResponse> TransferConfigurationGetAsync(Transfer.TransferConfigurationGetRequest request) =>
		PostAsync("/transfer/configuration/get", request)
			.ParseResponseAsync<Transfer.TransferConfigurationGetResponse>();

	/// <summary>
	/// <para>Use the <c>/transfer/metrics/get</c> endpoint to view your transfer product usage metrics.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transfermetricsget" /></remarks>
	public Task<Transfer.TransferMetricsGetResponse> TransferMetricsGetAsync(Transfer.TransferMetricsGetRequest request) =>
		PostAsync("/transfer/metrics/get", request)
			.ParseResponseAsync<Transfer.TransferMetricsGetResponse>();

	/// <summary>
	/// <para>Use the <c>/transfer/create</c> endpoint to initiate a new transfer.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transfercreate" /></remarks>
	public Task<Transfer.TransferCreateResponse> TransferCreateAsync(Transfer.TransferCreateRequest request) =>
		PostAsync("/transfer/create", request)
			.ParseResponseAsync<Transfer.TransferCreateResponse>();

	/// <summary>
	/// <para>Use the <c>/transfer/recurring/create</c> endpoint to initiate a new recurring transfer.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transferrecurringcreate" /></remarks>
	public Task<Transfer.TransferRecurringCreateResponse> TransferRecurringCreateAsync(Transfer.TransferRecurringCreateRequest request) =>
		PostAsync("/transfer/recurring/create", request)
			.ParseResponseAsync<Transfer.TransferRecurringCreateResponse>();

	/// <summary>
	/// <para>Use the <c>/transfer/list</c> endpoint to see a list of all your transfers and their statuses. Results are paginated; use the <c>count</c> and <c>offset</c> query parameters to retrieve the desired transfers.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transferlist" /></remarks>
	public Task<Transfer.TransferListResponse> TransferListAsync(Transfer.TransferListRequest request) =>
		PostAsync("/transfer/list", request)
			.ParseResponseAsync<Transfer.TransferListResponse>();

	/// <summary>
	/// <para>Use the <c>/transfer/recurring/list</c> endpoint to see a list of all your recurring transfers and their statuses. Results are paginated; use the <c>count</c> and <c>offset</c> query parameters to retrieve the desired recurring transfers.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transferrecurringlist" /></remarks>
	public Task<Transfer.TransferRecurringListResponse> TransferRecurringListAsync(Transfer.TransferRecurringListRequest request) =>
		PostAsync("/transfer/recurring/list", request)
			.ParseResponseAsync<Transfer.TransferRecurringListResponse>();

	/// <summary>
	/// <para>Use the <c>/transfer/cancel</c> endpoint to cancel a transfer.  A transfer is eligible for cancellation if the <c>cancellable</c> property returned by <c>/transfer/get</c> is <c>true</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transfercancel" /></remarks>
	public Task<Transfer.TransferCancelResponse> TransferCancelAsync(Transfer.TransferCancelRequest request) =>
		PostAsync("/transfer/cancel", request)
			.ParseResponseAsync<Transfer.TransferCancelResponse>();

	/// <summary>
	/// <para>Use the <c>/transfer/recurring/cancel</c> endpoint to cancel a recurring transfer.  Scheduled transfer that hasn't been submitted to bank will be cancelled.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transferrecurringcancel" /></remarks>
	public Task<Transfer.TransferRecurringCancelResponse> TransferRecurringCancelAsync(Transfer.TransferRecurringCancelRequest request) =>
		PostAsync("/transfer/recurring/cancel", request)
			.ParseResponseAsync<Transfer.TransferRecurringCancelResponse>();

	/// <summary>
	/// <para>Use the <c>/transfer/event/list</c> endpoint to get a list of transfer events based on specified filter criteria.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transfereventlist" /></remarks>
	public Task<Transfer.TransferEventListResponse> TransferEventListAsync(Transfer.TransferEventListRequest request) =>
		PostAsync("/transfer/event/list", request)
			.ParseResponseAsync<Transfer.TransferEventListResponse>();

	/// <summary>
	/// <para><c>/transfer/event/sync</c> allows you to request up to the next 25 transfer events that happened after a specific <c>event_id</c>. Use the <c>/transfer/event/sync</c> endpoint to guarantee you have seen all transfer events. When using Auth with micro-deposit verification enabled, this endpoint can be used to fetch status updates on ACH micro-deposits. For more details, see <a href="https://www.plaid.com/docs/auth/coverage/microdeposit-events/">micro-deposit events</a>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transfereventsync" /></remarks>
	public Task<Transfer.TransferEventSyncResponse> TransferEventSyncAsync(Transfer.TransferEventSyncRequest request) =>
		PostAsync("/transfer/event/sync", request)
			.ParseResponseAsync<Transfer.TransferEventSyncResponse>();

	/// <summary>
	/// <para>The <c>/transfer/sweep/get</c> endpoint fetches a sweep corresponding to the given <c>sweep_id</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transfersweepget" /></remarks>
	public Task<Transfer.TransferSweepGetResponse> TransferSweepGetAsync(Transfer.TransferSweepGetRequest request) =>
		PostAsync("/transfer/sweep/get", request)
			.ParseResponseAsync<Transfer.TransferSweepGetResponse>();

	/// <summary>
	/// <para>The <c>/transfer/sweep/list</c> endpoint fetches sweeps matching the given filters.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transfersweeplist" /></remarks>
	public Task<Transfer.TransferSweepListResponse> TransferSweepListAsync(Transfer.TransferSweepListRequest request) =>
		PostAsync("/transfer/sweep/list", request)
			.ParseResponseAsync<Transfer.TransferSweepListResponse>();

	/// <summary>
	/// <para>As an alternative to adding Items via Link, you can also use the <c>/transfer/migrate_account</c> endpoint to migrate known account and routing numbers to Plaid Items.  Note that Items created in this way are not compatible with endpoints for other products, such as <c>/accounts/balance/get</c>, and can only be used with Transfer endpoints.  If you require access to other endpoints, create the Item through Link instead.  Access to <c>/transfer/migrate_account</c> is not enabled by default; to obtain access, contact your Plaid Account Manager.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transfermigrate_account" /></remarks>
	public Task<Transfer.TransferMigrateAccountResponse> TransferMigrateAccountAsync(Transfer.TransferMigrateAccountRequest request) =>
		PostAsync("/transfer/migrate_account", request)
			.ParseResponseAsync<Transfer.TransferMigrateAccountResponse>();

	/// <summary>
	/// <para>Use the <c>/transfer/intent/create</c> endpoint to generate a transfer intent object and invoke the Transfer UI.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transferintentcreate" /></remarks>
	public Task<Transfer.TransferIntentCreateResponse> TransferIntentCreateAsync(Transfer.TransferIntentCreateRequest request) =>
		PostAsync("/transfer/intent/create", request)
			.ParseResponseAsync<Transfer.TransferIntentCreateResponse>();

	/// <summary>
	/// <para>Use the <c>/transfer/intent/get</c> endpoint to retrieve more information about a transfer intent.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transferintentget" /></remarks>
	public Task<Transfer.TransferIntentGetResponse> TransferIntentGetAsync(Transfer.TransferIntentGetRequest request) =>
		PostAsync("/transfer/intent/get", request)
			.ParseResponseAsync<Transfer.TransferIntentGetResponse>();

	/// <summary>
	/// <para>The <c>/transfer/repayment/list</c> endpoint fetches repayments matching the given filters. Repayments are returned in reverse-chronological order (most recent first) starting at the given <c>start_time</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transferrepaymentlist" /></remarks>
	public Task<Transfer.TransferRepaymentListResponse> TransferRepaymentListAsync(Transfer.TransferRepaymentListRequest request) =>
		PostAsync("/transfer/repayment/list", request)
			.ParseResponseAsync<Transfer.TransferRepaymentListResponse>();

	/// <summary>
	/// <para>The <c>/transfer/repayment/return/list</c> endpoint retrieves the set of returns that were batched together into the specified repayment. The sum of amounts of returns retrieved by this request equals the amount of the repayment.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transferrepaymentreturnlist" /></remarks>
	public Task<Transfer.TransferRepaymentReturnListResponse> TransferRepaymentReturnListAsync(Transfer.TransferRepaymentReturnListRequest request) =>
		PostAsync("/transfer/repayment/return/list", request)
			.ParseResponseAsync<Transfer.TransferRepaymentReturnListResponse>();

	/// <summary>
	/// <para>Use the <c>/transfer/originator/create</c> endpoint to create a new originator and return an <c>originator_client_id</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transferoriginatorcreate" /></remarks>
	public Task<Transfer.TransferOriginatorCreateResponse> TransferOriginatorCreateAsync(Transfer.TransferOriginatorCreateRequest request) =>
		PostAsync("/transfer/originator/create", request)
			.ParseResponseAsync<Transfer.TransferOriginatorCreateResponse>();

	/// <summary>
	/// <para>The <c>/transfer/questionnaire/create</c> endpoint generates a Plaid-hosted onboarding UI URL. Redirect the originator to this URL to provide their due diligence information and agree to Plaid’s terms for ACH money movement.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transferquestionnairecreate" /></remarks>
	public Task<Transfer.TransferQuestionnaireCreateResponse> TransferQuestionnaireCreateAsync(Transfer.TransferQuestionnaireCreateRequest request) =>
		PostAsync("/transfer/questionnaire/create", request)
			.ParseResponseAsync<Transfer.TransferQuestionnaireCreateResponse>();

	/// <summary>
	/// <para>Use the <c>/transfer/diligence/submit</c> endpoint to submit transfer diligence on behalf of the originator.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transferdiligencesubmit" /></remarks>
	public Task<Transfer.TransferDiligenceSubmitResponse> TransferDiligenceSubmitAsync(Transfer.TransferDiligenceSubmitRequest request) =>
		PostAsync("/transfer/diligence/submit", request)
			.ParseResponseAsync<Transfer.TransferDiligenceSubmitResponse>();

	/// <summary>
	/// <para>The <c>/transfer/originator/get</c> endpoint gets status updates for an originator's onboarding process. This information is also available via the Transfer page on the Plaid dashboard.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transferoriginatorget" /></remarks>
	public Task<Transfer.TransferOriginatorGetResponse> TransferOriginatorGetAsync(Transfer.TransferOriginatorGetRequest request) =>
		PostAsync("/transfer/originator/get", request)
			.ParseResponseAsync<Transfer.TransferOriginatorGetResponse>();

	/// <summary>
	/// <para>The <c>/transfer/originator/list</c> endpoint gets status updates for all of your originators' onboarding. This information is also available via the Plaid dashboard.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transferoriginatorlist" /></remarks>
	public Task<Transfer.TransferOriginatorListResponse> TransferOriginatorListAsync(Transfer.TransferOriginatorListRequest request) =>
		PostAsync("/transfer/originator/list", request)
			.ParseResponseAsync<Transfer.TransferOriginatorListResponse>();

	/// <summary>
	/// <para>Use the <c>/transfer/refund/create</c> endpoint to create a refund for a transfer. A transfer can be refunded if the transfer was initiated in the past 180 days.</para>
	/// <para>Processing of the refund will not occur until at least 3 business days following the transfer's settlement date, plus any hold/settlement delays. This 3-day window helps better protect your business from regular ACH returns. Consumer initiated returns (unauthorized returns) could still happen for about 60 days from the settlement date. If the original transfer is canceled, returned or failed, all pending refunds will automatically be canceled. Processed refunds cannot be revoked.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transferrefundcreate" /></remarks>
	public Task<Transfer.TransferRefundCreateResponse> TransferRefundCreateAsync(Transfer.TransferRefundCreateRequest request) =>
		PostAsync("/transfer/refund/create", request)
			.ParseResponseAsync<Transfer.TransferRefundCreateResponse>();

	/// <summary>
	/// <para>The <c>/transfer/refund/get</c> endpoint fetches information about the refund corresponding to the given <c>refund_id</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transferrefundget" /></remarks>
	public Task<Transfer.TransferRefundGetResponse> TransferRefundGetAsync(Transfer.TransferRefundGetRequest request) =>
		PostAsync("/transfer/refund/get", request)
			.ParseResponseAsync<Transfer.TransferRefundGetResponse>();

	/// <summary>
	/// <para>Use the <c>/transfer/refund/cancel</c> endpoint to cancel a refund.  A refund is eligible for cancellation if it has not yet been submitted to the payment network.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transferrefundcancel" /></remarks>
	public Task<Transfer.TransferRefundCancelResponse> TransferRefundCancelAsync(Transfer.TransferRefundCancelRequest request) =>
		PostAsync("/transfer/refund/cancel", request)
			.ParseResponseAsync<Transfer.TransferRefundCancelResponse>();
}