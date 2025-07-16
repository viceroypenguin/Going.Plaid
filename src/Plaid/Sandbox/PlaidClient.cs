namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Use the <c>/sandbox/transactions/create</c> endpoint to create new transactions for an existing Item. This endpoint can be used to add up to 10 transactions to any Item at a time.</para>
	/// <para>This endpoint is only available in the Sandbox environment, thus can only be used with Items that were created in the Sandbox. You can use this to add transactions to test the <c>/transactions/get</c> and <c>/transactions/sync</c> endpoints.</para>
	/// <para>For Items created in the Production environment, real transactions will be available once the transactions product is enabled.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/sandbox/#sandboxtransactionscreate" /></remarks>
	public Task<Sandbox.SandboxTransactionsCreateResponse> SandboxTransactionsCreateAsync(Sandbox.SandboxTransactionsCreateRequest request) =>
		PostAsync("/sandbox/transactions/create", request)
			.ParseResponseAsync<Sandbox.SandboxTransactionsCreateResponse>();

	/// <summary>
	/// <para>Use the <c>/sandbox/processor_token/create</c> endpoint to create a valid <c>processor_token</c> for an arbitrary institution ID and test credentials. The created <c>processor_token</c> corresponds to a new Sandbox Item. You can then use this <c>processor_token</c> with the <c>/processor/</c> API endpoints in Sandbox. You can also use <c>/sandbox/processor_token/create</c> with the <a href="https://plaid.com/docs/sandbox/user-custom"><c>user_custom</c> test username</a> to generate a test account with custom data.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/sandbox/#sandboxprocessor_tokencreate" /></remarks>
	public Task<Sandbox.SandboxProcessorTokenCreateResponse> SandboxProcessorTokenCreateAsync(Sandbox.SandboxProcessorTokenCreateRequest request) =>
		PostAsync("/sandbox/processor_token/create", request)
			.ParseResponseAsync<Sandbox.SandboxProcessorTokenCreateResponse>();

	/// <summary>
	/// <para>Use the <c>/sandbox/public_token/create</c> endpoint to create a valid <c>public_token</c>  for an arbitrary institution ID, initial products, and test credentials. The created <c>public_token</c> maps to a new Sandbox Item. You can then call <c>/item/public_token/exchange</c> to exchange the <c>public_token</c> for an <c>access_token</c> and perform all API actions. <c>/sandbox/public_token/create</c> can also be used with the <a href="https://plaid.com/docs/sandbox/user-custom"><c>user_custom</c> test username</a> to generate a test account with custom data, or with Plaid's <a href="https://plaid.com/docs/sandbox/test-credentials/">pre-populated Sandbox test accounts</a>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/sandbox/#sandboxpublic_tokencreate" /></remarks>
	public Task<Sandbox.SandboxPublicTokenCreateResponse> SandboxPublicTokenCreateAsync(Sandbox.SandboxPublicTokenCreateRequest request) =>
		PostAsync("/sandbox/public_token/create", request)
			.ParseResponseAsync<Sandbox.SandboxPublicTokenCreateResponse>();

	/// <summary>
	/// <para>The <c>/sandbox/item/fire_webhook</c> endpoint is used to test that code correctly handles webhooks. This endpoint can trigger the following webhooks:</para>
	/// <para><c>DEFAULT_UPDATE</c>: Webhook to be fired for a given Sandbox Item simulating a default update event for the respective product as specified with the <c>webhook_type</c> in the request body. Valid Sandbox <c>DEFAULT_UPDATE</c> webhook types include: <c>AUTH</c>, <c>IDENTITY</c>, <c>TRANSACTIONS</c>, <c>INVESTMENTS_TRANSACTIONS</c>, <c>LIABILITIES</c>, <c>HOLDINGS</c>. If the Item does not support the product, a <c>SANDBOX_PRODUCT_NOT_ENABLED</c> error will result.</para>
	/// <para><c>NEW_ACCOUNTS_AVAILABLE</c>: Fired to indicate that a new account is available on the Item and you can launch update mode to request access to it.</para>
	/// <para><c>SMS_MICRODEPOSITS_VERIFICATION</c>: Fired when a given same day micro-deposit item is verified via SMS verification.</para>
	/// <para><c>LOGIN_REPAIRED</c>: Fired when an Item recovers from the <c>ITEM_LOGIN_REQUIRED</c> without the user going through update mode in your app.</para>
	/// <para><c>PENDING_DISCONNECT</c>: Fired when an Item will stop working in the near future (e.g. due to a planned bank migration) and must be sent through update mode to continue working.</para>
	/// <para><c>RECURRING_TRANSACTIONS_UPDATE</c>: Recurring Transactions webhook to be fired for a given Sandbox Item. If the Item does not support Recurring Transactions, a <c>SANDBOX_PRODUCT_NOT_ENABLED</c> error will result.</para>
	/// <para><c>SYNC_UPDATES_AVAILABLE</c>: Transactions webhook to be fired for a given Sandbox Item.  If the Item does not support Transactions, a <c>SANDBOX_PRODUCT_NOT_ENABLED</c> error will result.</para>
	/// <para><c>PRODUCT_READY</c>: Assets webhook to be fired when a given asset report has been successfully generated. If the Item does not support Assets, a <c>SANDBOX_PRODUCT_NOT_ENABLED</c> error will result.</para>
	/// <para><c>ERROR</c>: Assets webhook to be fired when asset report generation has failed. If the Item does not support Assets, a <c>SANDBOX_PRODUCT_NOT_ENABLED</c> error will result.</para>
	/// <para><c>USER_PERMISSION_REVOKED</c>: Indicates an end user has revoked the permission that they previously granted to access an Item. May not always fire upon revocation, as some institutions’ consent portals do not trigger this webhook. Upon receiving this webhook, it is recommended to delete any stored data from Plaid associated with the account or Item.</para>
	/// <para><c>USER_ACCOUNT_REVOKED</c>: Fired when an end user has revoked access to their account on the Data Provider's portal. This webhook is currently sent only for Chase and PNC Items, but may be sent in the future for other financial institutions. Upon receiving this webhook, it is recommended to delete any stored data from Plaid associated with the account or Item.</para>
	/// <para>Note that this endpoint is provided for developer ease-of-use and is not required for testing webhooks; webhooks will also fire in Sandbox under the same conditions that they would in Production (except for webhooks of type <c>TRANSFER</c>).</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/sandbox/#sandboxitemfire_webhook" /></remarks>
	public Task<Sandbox.SandboxItemFireWebhookResponse> SandboxItemFireWebhookAsync(Sandbox.SandboxItemFireWebhookRequest request) =>
		PostAsync("/sandbox/item/fire_webhook", request)
			.ParseResponseAsync<Sandbox.SandboxItemFireWebhookResponse>();

	/// <summary>
	/// <para><c>/sandbox/item/reset_login/</c> forces an Item into an <c>ITEM_LOGIN_REQUIRED</c> state in order to simulate an Item whose login is no longer valid. This makes it easy to test Link's <a href="https://plaid.com/docs/link/update-mode">update mode</a> flow in the Sandbox environment.  After calling <c>/sandbox/item/reset_login</c>, You can then use Plaid Link update mode to restore the Item to a good state. An <c>ITEM_LOGIN_REQUIRED</c> webhook will also be fired after a call to this endpoint, if one is associated with the Item.</para>
	/// <para>In the Sandbox, Items will transition to an <c>ITEM_LOGIN_REQUIRED</c> error state automatically after 30 days, even if this endpoint is not called.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/sandbox/#sandboxitemreset_login" /></remarks>
	public Task<Sandbox.SandboxItemResetLoginResponse> SandboxItemResetLoginAsync(Sandbox.SandboxItemResetLoginRequest request) =>
		PostAsync("/sandbox/item/reset_login", request)
			.ParseResponseAsync<Sandbox.SandboxItemResetLoginResponse>();

	/// <summary>
	/// <para>The <c>/sandbox/item/set_verification_status</c> endpoint can be used to change the verification status of an Item in in the Sandbox in order to simulate the Automated Micro-deposit flow.</para>
	/// <para>For more information on testing Automated Micro-deposits in Sandbox, see <a href="https://plaid.com/docs/auth/coverage/testing#">Auth full coverage testing</a>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/sandbox/#sandboxitemset_verification_status" /></remarks>
	public Task<Sandbox.SandboxItemSetVerificationStatusResponse> SandboxItemSetVerificationStatusAsync(Sandbox.SandboxItemSetVerificationStatusRequest request) =>
		PostAsync("/sandbox/item/set_verification_status", request)
			.ParseResponseAsync<Sandbox.SandboxItemSetVerificationStatusResponse>();

	/// <summary>
	/// <para><c>/sandbox/user/reset_login/</c> functions the same as <c>/sandbox/item/reset_login</c>, but will modify Items related to a User. This endpoint forces each Item into an <c>ITEM_LOGIN_REQUIRED</c> state in order to simulate an Item whose login is no longer valid. This makes it easy to test Link's <a href="https://plaid.com/docs/link/update-mode">update mode</a> flow in the Sandbox environment.  After calling <c>/sandbox/user/reset_login</c>, You can then use Plaid Link update mode to restore Items associated with the User to a good state. An <c>ITEM_LOGIN_REQUIRED</c> webhook will also be fired after a call to this endpoint, if one is associated with the Item.</para>
	/// <para>In the Sandbox, Items will transition to an <c>ITEM_LOGIN_REQUIRED</c> error state automatically after 30 days, even if this endpoint is not called.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/sandbox/#sandboxuserreset_login" /></remarks>
	public Task<Sandbox.SandboxUserResetLoginResponse> SandboxUserResetLoginAsync(Sandbox.SandboxUserResetLoginRequest request) =>
		PostAsync("/sandbox/user/reset_login", request)
			.ParseResponseAsync<Sandbox.SandboxUserResetLoginResponse>();

	/// <summary>
	/// <para>Use the <c>/sandbox/bank_transfer/simulate</c> endpoint to simulate a bank transfer event in the Sandbox environment.  Note that while an event will be simulated and will appear when using endpoints such as <c>/bank_transfer/event/sync</c> or <c>/bank_transfer/event/list</c>, no transactions will actually take place and funds will not move between accounts, even within the Sandbox.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/bank-transfers/reference/#sandboxbank_transfersimulate" /></remarks>
	public Task<Sandbox.SandboxBankTransferSimulateResponse> SandboxBankTransferSimulateAsync(Sandbox.SandboxBankTransferSimulateRequest request) =>
		PostAsync("/sandbox/bank_transfer/simulate", request)
			.ParseResponseAsync<Sandbox.SandboxBankTransferSimulateResponse>();

	/// <summary>
	/// <para>Use the <c>/sandbox/transfer/sweep/simulate</c> endpoint to create a sweep and associated events in the Sandbox environment. Upon calling this endpoint, all transfers with a sweep status of <c>swept</c> will become <c>swept_settled</c>, all <c>posted</c> or <c>pending</c> transfers with a sweep status of <c>unswept</c> will become <c>swept</c>, and all <c>returned</c> transfers with a sweep status of <c>swept</c> will become <c>return_swept</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/sandbox/#sandboxtransfersweepsimulate" /></remarks>
	public Task<Sandbox.SandboxTransferSweepSimulateResponse> SandboxTransferSweepSimulateAsync(Sandbox.SandboxTransferSweepSimulateRequest request) =>
		PostAsync("/sandbox/transfer/sweep/simulate", request)
			.ParseResponseAsync<Sandbox.SandboxTransferSweepSimulateResponse>();

	/// <summary>
	/// <para>Use the <c>/sandbox/transfer/simulate</c> endpoint to simulate a transfer event in the Sandbox environment.  Note that while an event will be simulated and will appear when using endpoints such as <c>/transfer/event/sync</c> or <c>/transfer/event/list</c>, no transactions will actually take place and funds will not move between accounts, even within the Sandbox.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/sandbox/#sandboxtransfersimulate" /></remarks>
	public Task<Sandbox.SandboxTransferSimulateResponse> SandboxTransferSimulateAsync(Sandbox.SandboxTransferSimulateRequest request) =>
		PostAsync("/sandbox/transfer/simulate", request)
			.ParseResponseAsync<Sandbox.SandboxTransferSimulateResponse>();

	/// <summary>
	/// <para>Use the <c>/sandbox/transfer/refund/simulate</c> endpoint to simulate a refund event in the Sandbox environment.  Note that while an event will be simulated and will appear when using endpoints such as <c>/transfer/event/sync</c> or <c>/transfer/event/list</c>, no transactions will actually take place and funds will not move between accounts, even within the Sandbox.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/sandbox/#sandboxtransferrefundsimulate" /></remarks>
	public Task<Sandbox.SandboxTransferRefundSimulateResponse> SandboxTransferRefundSimulateAsync(Sandbox.SandboxTransferRefundSimulateRequest request) =>
		PostAsync("/sandbox/transfer/refund/simulate", request)
			.ParseResponseAsync<Sandbox.SandboxTransferRefundSimulateResponse>();

	/// <summary>
	/// <para>Use the <c>/sandbox/transfer/ledger/simulate_available</c> endpoint to simulate converting pending balance to available balance for all originators in the Sandbox environment.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/sandbox/#sandboxtransferledgersimulate_available" /></remarks>
	public Task<Sandbox.SandboxTransferLedgerSimulateAvailableResponse> SandboxTransferLedgerSimulateAvailableAsync(Sandbox.SandboxTransferLedgerSimulateAvailableRequest request) =>
		PostAsync("/sandbox/transfer/ledger/simulate_available", request)
			.ParseResponseAsync<Sandbox.SandboxTransferLedgerSimulateAvailableResponse>();

	/// <summary>
	/// <para>Use the <c>/sandbox/transfer/ledger/deposit/simulate</c> endpoint to simulate a ledger deposit event in the Sandbox environment.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/sandbox/#sandboxtransferledgerdepositsimulate" /></remarks>
	public Task<Sandbox.SandboxTransferLedgerDepositSimulateResponse> SandboxTransferLedgerDepositSimulateAsync(Sandbox.SandboxTransferLedgerDepositSimulateRequest request) =>
		PostAsync("/sandbox/transfer/ledger/deposit/simulate", request)
			.ParseResponseAsync<Sandbox.SandboxTransferLedgerDepositSimulateResponse>();

	/// <summary>
	/// <para>Use the <c>/sandbox/transfer/ledger/withdraw/simulate</c> endpoint to simulate a ledger withdraw event in the Sandbox environment.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/sandbox/#sandboxtransferledgerwithdrawsimulate" /></remarks>
	public Task<Sandbox.SandboxTransferLedgerWithdrawSimulateResponse> SandboxTransferLedgerWithdrawSimulateAsync(Sandbox.SandboxTransferLedgerWithdrawSimulateRequest request) =>
		PostAsync("/sandbox/transfer/ledger/withdraw/simulate", request)
			.ParseResponseAsync<Sandbox.SandboxTransferLedgerWithdrawSimulateResponse>();

	/// <summary>
	/// <para>Use the <c>/sandbox/transfer/repayment/simulate</c> endpoint to trigger the creation of a repayment. As a side effect of calling this route, a repayment is created that includes all unreimbursed returns of guaranteed transfers. If there are no such returns, an 400 error is returned.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/sandbox/#sandboxtransferrepaymentsimulate" /></remarks>
	public Task<Sandbox.SandboxTransferRepaymentSimulateResponse> SandboxTransferRepaymentSimulateAsync(Sandbox.SandboxTransferRepaymentSimulateRequest request) =>
		PostAsync("/sandbox/transfer/repayment/simulate", request)
			.ParseResponseAsync<Sandbox.SandboxTransferRepaymentSimulateResponse>();

	/// <summary>
	/// <para>Use the <c>/sandbox/transfer/fire_webhook</c> endpoint to manually trigger a <c>TRANSFER_EVENTS_UPDATE</c> webhook in the Sandbox environment.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/sandbox/#sandboxtransferfire_webhook" /></remarks>
	public Task<Sandbox.SandboxTransferFireWebhookResponse> SandboxTransferFireWebhookAsync(Sandbox.SandboxTransferFireWebhookRequest request) =>
		PostAsync("/sandbox/transfer/fire_webhook", request)
			.ParseResponseAsync<Sandbox.SandboxTransferFireWebhookResponse>();

	/// <summary>
	/// <para>Use the <c>/sandbox/transfer/test_clock/create</c> endpoint to create a <c>test_clock</c> in the Sandbox environment.</para>
	/// <para>A test clock object represents an independent timeline and has a <c>virtual_time</c> field indicating the current timestamp of the timeline. Test clocks are used for testing recurring transfers in Sandbox.</para>
	/// <para>A test clock can be associated with up to 5 recurring transfers.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/sandbox/#sandboxtransfertest_clockcreate" /></remarks>
	public Task<Sandbox.SandboxTransferTestClockCreateResponse> SandboxTransferTestClockCreateAsync(Sandbox.SandboxTransferTestClockCreateRequest request) =>
		PostAsync("/sandbox/transfer/test_clock/create", request)
			.ParseResponseAsync<Sandbox.SandboxTransferTestClockCreateResponse>();

	/// <summary>
	/// <para>Use the <c>/sandbox/transfer/test_clock/advance</c> endpoint to advance a <c>test_clock</c> in the Sandbox environment.</para>
	/// <para>A test clock object represents an independent timeline and has a <c>virtual_time</c> field indicating the current timestamp of the timeline. A test clock can be advanced by incrementing <c>virtual_time</c>, but may never go back to a lower <c>virtual_time</c>.</para>
	/// <para>If a test clock is advanced, we will simulate the changes that ought to occur during the time that elapsed.</para>
	/// <para>For example, a client creates a weekly recurring transfer with a test clock set at t. When the client advances the test clock by setting <c>virtual_time</c> = t + 15 days, 2 new originations should be created, along with the webhook events.</para>
	/// <para>The advancement of the test clock from its current <c>virtual_time</c> should be limited such that there are no more than 20 originations resulting from the advance operation on each <c>recurring_transfer</c> associated with the <c>test_clock</c>.</para>
	/// <para>For example, if the recurring transfer associated with this test clock originates once every 4 weeks, you can advance the <c>virtual_time</c> up to 80 weeks on each API call.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/sandbox/#sandboxtransfertest_clockadvance" /></remarks>
	public Task<Sandbox.SandboxTransferTestClockAdvanceResponse> SandboxTransferTestClockAdvanceAsync(Sandbox.SandboxTransferTestClockAdvanceRequest request) =>
		PostAsync("/sandbox/transfer/test_clock/advance", request)
			.ParseResponseAsync<Sandbox.SandboxTransferTestClockAdvanceResponse>();

	/// <summary>
	/// <para>Use the <c>/sandbox/transfer/test_clock/get</c> endpoint to get a <c>test_clock</c> in the Sandbox environment.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/sandbox/#sandboxtransfertest_clockget" /></remarks>
	public Task<Sandbox.SandboxTransferTestClockGetResponse> SandboxTransferTestClockGetAsync(Sandbox.SandboxTransferTestClockGetRequest request) =>
		PostAsync("/sandbox/transfer/test_clock/get", request)
			.ParseResponseAsync<Sandbox.SandboxTransferTestClockGetResponse>();

	/// <summary>
	/// <para>Use the <c>/sandbox/transfer/test_clock/list</c> endpoint to see a list of all your test clocks in the Sandbox environment, by ascending <c>virtual_time</c>. Results are paginated; use the <c>count</c> and <c>offset</c> query parameters to retrieve the desired test clocks.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/sandbox/#sandboxtransfertest_clocklist" /></remarks>
	public Task<Sandbox.SandboxTransferTestClockListResponse> SandboxTransferTestClockListAsync(Sandbox.SandboxTransferTestClockListRequest request) =>
		PostAsync("/sandbox/transfer/test_clock/list", request)
			.ParseResponseAsync<Sandbox.SandboxTransferTestClockListResponse>();

	/// <summary>
	/// <para><c>/sandbox/payment_profile/reset_login/</c> forces a Payment Profile into a state where the login is no longer valid. This makes it easy to test update mode for Payment Profile in the Sandbox environment.</para>
	/// <para> After calling <c>/sandbox/payment_profile/reset_login</c>, calls to the <c>/transfer/authorization/create</c> with the Payment Profile will result in a <c>decision_rationale</c> <c>PAYMENT_PROFILE_LOGIN_REQUIRED</c>. You can then use update mode for Payment Profile to restore it into a good state.</para>
	/// <para> In order to invoke this endpoint, you must first <a href="https://plaid.com/docs/transfer/add-to-app/#create-a-payment-profile-optional">create a Payment Profile</a> and <a href="https://plaid.com/docs/transfer/add-to-app/#create-a-link-token">go through the Link flow</a>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/sandbox/#sandboxpayment_profilereset_login" /></remarks>
	public Task<Sandbox.SandboxPaymentProfileResetLoginResponse> SandboxPaymentProfileResetLoginAsync(Sandbox.SandboxPaymentProfileResetLoginRequest request) =>
		PostAsync("/sandbox/payment_profile/reset_login", request)
			.ParseResponseAsync<Sandbox.SandboxPaymentProfileResetLoginResponse>();

	/// <summary>
	/// <para>Use the <c>/sandbox/payment/simulate</c> endpoint to simulate various payment events in the Sandbox environment. This endpoint will trigger the corresponding payment status webhook.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/sandbox/#sandboxpaymentsimulate" /></remarks>
	public Task<Sandbox.SandboxPaymentSimulateResponse> SandboxPaymentSimulateAsync(Sandbox.SandboxPaymentSimulateRequest request) =>
		PostAsync("/sandbox/payment/simulate", request)
			.ParseResponseAsync<Sandbox.SandboxPaymentSimulateResponse>();

	/// <summary>
	/// <para>Use the <c>/sandbox/bank_transfer/fire_webhook</c> endpoint to manually trigger a Bank Transfers webhook in the Sandbox environment.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/bank-transfers/reference/#sandboxbank_transferfire_webhook" /></remarks>
	public Task<Sandbox.SandboxBankTransferFireWebhookResponse> SandboxBankTransferFireWebhookAsync(Sandbox.SandboxBankTransferFireWebhookRequest request) =>
		PostAsync("/sandbox/bank_transfer/fire_webhook", request)
			.ParseResponseAsync<Sandbox.SandboxBankTransferFireWebhookResponse>();

	/// <summary>
	/// <para>Use the <c>/sandbox/income/fire_webhook</c> endpoint to manually trigger a Payroll or Document Income webhook in the Sandbox environment.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/sandbox/#sandboxincomefire_webhook" /></remarks>
	public Task<Sandbox.SandboxIncomeFireWebhookResponse> SandboxIncomeFireWebhookAsync(Sandbox.SandboxIncomeFireWebhookRequest request) =>
		PostAsync("/sandbox/income/fire_webhook", request)
			.ParseResponseAsync<Sandbox.SandboxIncomeFireWebhookResponse>();

	/// <summary>
	/// <para>Use the <c>/sandbox/bank_income/fire_webhook</c> endpoint to manually trigger a Bank Income webhook in the Sandbox environment.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/sandbox/#sandboxbankincomefire_webhook" /></remarks>
	public Task<Sandbox.SandboxBankIncomeFireWebhookResponse> SandboxBankIncomeFireWebhookAsync(Sandbox.SandboxBankIncomeFireWebhookRequest request) =>
		PostAsync("/sandbox/bank_income/fire_webhook", request)
			.ParseResponseAsync<Sandbox.SandboxBankIncomeFireWebhookResponse>();

	/// <summary>
	/// <para>Use the <c>/sandbox/cra/cashflow_updates/update</c> endpoint to manually trigger an update for Cash Flow Updates (Monitoring) in the Sandbox environment.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/sandbox/#sandboxcracashflow_updatesupdate" /></remarks>
	public Task<Sandbox.SandboxCraCashflowUpdatesUpdateResponse> SandboxCraCashflowUpdatesUpdateAsync(Sandbox.SandboxCraCashflowUpdatesUpdateRequest request) =>
		PostAsync("/sandbox/cra/cashflow_updates/update", request)
			.ParseResponseAsync<Sandbox.SandboxCraCashflowUpdatesUpdateResponse>();

	/// <summary>
	/// <para>Save the selected accounts when connecting to the Platypus Oauth institution</para>
	/// </summary>
	public Task<Sandbox.SandboxOauthSelectAccountsResponse> SandboxOauthSelectAccountsAsync(Sandbox.SandboxOauthSelectAccountsRequest request) =>
		PostAsync("/sandbox/oauth/select_accounts", request)
			.ParseResponseAsync<Sandbox.SandboxOauthSelectAccountsResponse>();

}
