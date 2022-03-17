namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/bank_transfer/get</c> fetches information about the bank transfer corresponding to the given <c>bank_transfer_id</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/bank-transfers/reference#bank_transferget" /></remarks>
	public Task<BankTransfer.BankTransferGetResponse> BankTransferGetAsync(BankTransfer.BankTransferGetRequest request) =>
		PostAsync("/bank_transfer/get", request)
			.ParseResponseAsync<BankTransfer.BankTransferGetResponse>();

	/// <summary>
	/// <para>Use the <c>/bank_transfer/create</c> endpoint to initiate a new bank transfer.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/bank-transfers/reference#bank_transfercreate" /></remarks>
	public Task<BankTransfer.BankTransferCreateResponse> BankTransferCreateAsync(BankTransfer.BankTransferCreateRequest request) =>
		PostAsync("/bank_transfer/create", request)
			.ParseResponseAsync<BankTransfer.BankTransferCreateResponse>();

	/// <summary>
	/// <para>Use the <c>/bank_transfer/list</c> endpoint to see a list of all your bank transfers and their statuses. Results are paginated; use the <c>count</c> and <c>offset</c> query parameters to retrieve the desired bank transfers.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/bank-transfers/reference#bank_transferlist" /></remarks>
	public Task<BankTransfer.BankTransferListResponse> BankTransferListAsync(BankTransfer.BankTransferListRequest request) =>
		PostAsync("/bank_transfer/list", request)
			.ParseResponseAsync<BankTransfer.BankTransferListResponse>();

	/// <summary>
	/// <para>Use the <c>/bank_transfer/cancel</c> endpoint to cancel a bank transfer.  A transfer is eligible for cancelation if the <c>cancellable</c> property returned by <c>/bank_transfer/get</c> is <c>true</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/bank-transfers/reference#bank_transfercancel" /></remarks>
	public Task<BankTransfer.BankTransferCancelResponse> BankTransferCancelAsync(BankTransfer.BankTransferCancelRequest request) =>
		PostAsync("/bank_transfer/cancel", request)
			.ParseResponseAsync<BankTransfer.BankTransferCancelResponse>();

	/// <summary>
	/// <para>Use the <c>/bank_transfer/event/list</c> endpoint to get a list of bank transfer events based on specified filter criteria.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/bank-transfers/reference#bank_transfereventlist" /></remarks>
	public Task<BankTransfer.BankTransferEventListResponse> BankTransferEventListAsync(BankTransfer.BankTransferEventListRequest request) =>
		PostAsync("/bank_transfer/event/list", request)
			.ParseResponseAsync<BankTransfer.BankTransferEventListResponse>();

	/// <summary>
	/// <para><c>/bank_transfer/event/sync</c> allows you to request up to the next 25 bank transfer events that happened after a specific <c>event_id</c>. Use the <c>/bank_transfer/event/sync</c> endpoint to guarantee you have seen all bank transfer events.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/bank-transfers/reference#bank_transfereventsync" /></remarks>
	public Task<BankTransfer.BankTransferEventSyncResponse> BankTransferEventSyncAsync(BankTransfer.BankTransferEventSyncRequest request) =>
		PostAsync("/bank_transfer/event/sync", request)
			.ParseResponseAsync<BankTransfer.BankTransferEventSyncResponse>();

	/// <summary>
	/// <para>The <c>/bank_transfer/sweep/get</c> endpoint fetches information about the sweep corresponding to the given <c>sweep_id</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#bank_transfersweepget" /></remarks>
	public Task<BankTransfer.BankTransferSweepGetResponse> BankTransferSweepGetAsync(BankTransfer.BankTransferSweepGetRequest request) =>
		PostAsync("/bank_transfer/sweep/get", request)
			.ParseResponseAsync<BankTransfer.BankTransferSweepGetResponse>();

	/// <summary>
	/// <para>The <c>/bank_transfer/sweep/list</c> endpoint fetches information about the sweeps matching the given filters.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/transfer/#bank_transfersweeplist" /></remarks>
	public Task<BankTransfer.BankTransferSweepListResponse> BankTransferSweepListAsync(BankTransfer.BankTransferSweepListRequest request) =>
		PostAsync("/bank_transfer/sweep/list", request)
			.ParseResponseAsync<BankTransfer.BankTransferSweepListResponse>();

	/// <summary>
	/// <para>Use the <c>/bank_transfer/balance/get</c> endpoint to see the available balance in your bank transfer account. Debit transfers increase this balance once their status is posted. Credit transfers decrease this balance when they are created.</para>
	/// <para>The transactable balance shows the amount in your account that you are able to use for transfers, and is essentially your available balance minus your minimum balance.</para>
	/// <para>Note that this endpoint can only be used with FBO accounts, when using Bank Transfers in the Full Service configuration. It cannot be used on your own account when using Bank Transfers in the BTS Platform configuration.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/bank-transfers/reference#bank_transferbalanceget" /></remarks>
	public Task<BankTransfer.BankTransferBalanceGetResponse> BankTransferBalanceGetAsync(BankTransfer.BankTransferBalanceGetRequest request) =>
		PostAsync("/bank_transfer/balance/get", request)
			.ParseResponseAsync<BankTransfer.BankTransferBalanceGetResponse>();

	/// <summary>
	/// <para>As an alternative to adding Items via Link, you can also use the <c>/bank_transfer/migrate_account</c> endpoint to migrate known account and routing numbers to Plaid Items.  Note that Items created in this way are not compatible with endpoints for other products, such as <c>/accounts/balance/get</c>, and can only be used with Bank Transfer endpoints.  If you require access to other endpoints, create the Item through Link instead.  Access to <c>/bank_transfer/migrate_account</c> is not enabled by default; to obtain access, contact your Plaid Account Manager.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/bank-transfers/reference#bank_transfermigrate_account" /></remarks>
	public Task<BankTransfer.BankTransferMigrateAccountResponse> BankTransferMigrateAccountAsync(BankTransfer.BankTransferMigrateAccountRequest request) =>
		PostAsync("/bank_transfer/migrate_account", request)
			.ParseResponseAsync<BankTransfer.BankTransferMigrateAccountResponse>();
}