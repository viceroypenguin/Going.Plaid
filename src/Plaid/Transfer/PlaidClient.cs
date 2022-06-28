namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/transfer/get</c> fetches information about the transfer corresponding to the given <c>transfer_id</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transferget" /></remarks>
	public Task<Transfer.TransferGetResponse> TransferGetAsync(Transfer.TransferGetRequest request) =>
		PostAsync("/transfer/get", request)
			.ParseResponseAsync<Transfer.TransferGetResponse>();

	/// <summary>
	/// <para>Use the <c>/transfer/authorization/create</c> endpoint to determine transfer failure risk.</para>
	/// <para>In Plaid's sandbox environment the decisions will be returned as follows:</para>
	/// <para>  - To approve a transfer with null rationale code, make an authorization request with an <c>amount</c> less than the available balance in the account.</para>
	/// <para>  - To approve a transfer with the rationale code <c>MANUALLY_VERIFIED_ITEM</c>, create an Item in Link through the <a href="https://plaid.com/docs/auth/coverage/testing/#testing-same-day-micro-deposits">Same Day Micro-deposits flow</a>.</para>
	/// <para>  - To approve a transfer with the rationale code <c>LOGIN_REQUIRED</c>, <a href="https://plaid.com/docs/sandbox/#item_login_required">reset the login for an Item</a>.</para>
	/// <para>  - To decline a transfer with the rationale code <c>NSF</c>, the available balance on the account must be less than the authorization <c>amount</c>. See <a href="https://plaid.com/docs/sandbox/user-custom/">Create Sandbox test data</a> for details on how to customize data in Sandbox.</para>
	/// <para>  - To decline a transfer with the rationale code <c>RISK</c>, the available balance on the account must be exactly $0. See <a href="https://plaid.com/docs/sandbox/user-custom/">Create Sandbox test data</a> for details on how to customize data in Sandbox.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transferauthorizationcreate" /></remarks>
	public Task<Transfer.TransferAuthorizationCreateResponse> TransferAuthorizationCreateAsync(Transfer.TransferAuthorizationCreateRequest request) =>
		PostAsync("/transfer/authorization/create", request)
			.ParseResponseAsync<Transfer.TransferAuthorizationCreateResponse>();

	/// <summary>
	/// <para>Use the <c>/transfer/create</c> endpoint to initiate a new transfer.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transfercreate" /></remarks>
	public Task<Transfer.TransferCreateResponse> TransferCreateAsync(Transfer.TransferCreateRequest request) =>
		PostAsync("/transfer/create", request)
			.ParseResponseAsync<Transfer.TransferCreateResponse>();

	/// <summary>
	/// <para>Use the <c>/transfer/list</c> endpoint to see a list of all your transfers and their statuses. Results are paginated; use the <c>count</c> and <c>offset</c> query parameters to retrieve the desired transfers.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transferlist" /></remarks>
	public Task<Transfer.TransferListResponse> TransferListAsync(Transfer.TransferListRequest request) =>
		PostAsync("/transfer/list", request)
			.ParseResponseAsync<Transfer.TransferListResponse>();

	/// <summary>
	/// <para>Use the <c>/transfer/cancel</c> endpoint to cancel a transfer.  A transfer is eligible for cancelation if the <c>cancellable</c> property returned by <c>/transfer/get</c> is <c>true</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transfercancel" /></remarks>
	public Task<Transfer.TransferCancelResponse> TransferCancelAsync(Transfer.TransferCancelRequest request) =>
		PostAsync("/transfer/cancel", request)
			.ParseResponseAsync<Transfer.TransferCancelResponse>();

	/// <summary>
	/// <para>Use the <c>/transfer/event/list</c> endpoint to get a list of transfer events based on specified filter criteria.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#transfereventlist" /></remarks>
	public Task<Transfer.TransferEventListResponse> TransferEventListAsync(Transfer.TransferEventListRequest request) =>
		PostAsync("/transfer/event/list", request)
			.ParseResponseAsync<Transfer.TransferEventListResponse>();

	/// <summary>
	/// <para><c>/transfer/event/sync</c> allows you to request up to the next 25 transfer events that happened after a specific <c>event_id</c>. Use the <c>/transfer/event/sync</c> endpoint to guarantee you have seen all transfer events.</para>
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
}