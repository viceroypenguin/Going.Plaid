namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>Use the <c>/sandbox/processor_token/create</c> endpoint to create a valid <c>processor_token</c> for an arbitrary institution ID and test credentials. The created <c>processor_token</c> corresponds to a new Sandbox Item. You can then use this <c>processor_token</c> with the <c>/processor/</c> API endpoints in Sandbox. You can also use <c>/sandbox/processor_token/create</c> with the <a href="https://plaid.com/docs/sandbox/user-custom"><c>user_custom</c> test username</a> to generate a test account with custom data.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/api/sandbox/#sandboxprocessor_tokencreate" /></remarks>
	public Task<Sandbox.SandboxProcessorTokenCreateResponse> SandboxProcessorTokenCreateAsync(Sandbox.SandboxProcessorTokenCreateRequest request) =>
		PostAsync("/sandbox/processor_token/create", request)
			.ParseResponseAsync<Sandbox.SandboxProcessorTokenCreateResponse>();

	/// <summary>
	/// <para>Use the <c>/sandbox/public_token/create</c>  endpoint to create a valid <c>public_token</c>  for an arbitrary institution ID, initial products, and test credentials. The created <c>public_token</c> maps to a new Sandbox Item. You can then call <c>/item/public_token/exchange</c> to exchange the <c>public_token</c> for an <c>access_token</c> and perform all API actions. <c>/sandbox/public_token/create</c> can also be used with the <a href="https://plaid.com/docs/sandbox/user-custom"><c>user_custom</c> test username</a> to generate a test account with custom data.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/api/sandbox/#sandboxpublic_tokencreate" /></remarks>
	public Task<Sandbox.SandboxPublicTokenCreateResponse> SandboxPublicTokenCreateAsync(Sandbox.SandboxPublicTokenCreateRequest request) =>
		PostAsync("/sandbox/public_token/create", request)
			.ParseResponseAsync<Sandbox.SandboxPublicTokenCreateResponse>();

	/// <summary>
	/// <para>The <c>/sandbox/item/fire_webhook</c> endpoint is used to test that code correctly handles webhooks. Calling this endpoint triggers a Transactions <c>DEFAULT_UPDATE</c> webhook to be fired for a given Sandbox Item. If the Item does not support Transactions, a <c>SANDBOX_PRODUCT_NOT_ENABLED</c> error will result.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/api/sandbox/#sandboxitemfire_webhook" /></remarks>
	public Task<Sandbox.SandboxItemFireWebhookResponse> SandboxItemFireWebhookAsync(Sandbox.SandboxItemFireWebhookRequest request) =>
		PostAsync("/sandbox/item/fire_webhook", request)
			.ParseResponseAsync<Sandbox.SandboxItemFireWebhookResponse>();

	/// <summary>
	/// <para><c>/sandbox/item/reset_login/</c> forces an Item into an <c>ITEM_LOGIN_REQUIRED</c> state in order to simulate an Item whose login is no longer valid. This makes it easy to test Link's <a href="https://plaid.com/docs/link/update-mode">update mode</a> flow in the Sandbox environment.  After calling <c>/sandbox/item/reset_login</c>, You can then use Plaid Link update mode to restore the Item to a good state. An <c>ITEM_LOGIN_REQUIRED</c> webhook will also be fired after a call to this endpoint, if one is associated with the Item.</para>
	/// <para>In the Sandbox, Items will transition to an <c>ITEM_LOGIN_REQUIRED</c> error state automatically after 30 days, even if this endpoint is not called.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/api/sandbox/#sandboxitemreset_login" /></remarks>
	public Task<Sandbox.SandboxItemResetLoginResponse> SandboxItemResetLoginAsync(Sandbox.SandboxItemResetLoginRequest request) =>
		PostAsync("/sandbox/item/reset_login", request)
			.ParseResponseAsync<Sandbox.SandboxItemResetLoginResponse>();

	/// <summary>
	/// <para>The <c>/sandbox/item/set_verification_status</c> endpoint can be used to change the verification status of an Item in in the Sandbox in order to simulate the Automated Micro-deposit flow.</para>
	/// <para>Note that not all Plaid developer accounts are enabled for micro-deposit based verification by default. Your account must be enabled for this feature in order to test it in Sandbox. To enable this features or check your status, contact your account manager or <a href="https://dashboard.plaid.com/support/new/product-and-development/product-troubleshooting/request-product-access">submit a product access Support ticket</a>.</para>
	/// <para>For more information on testing Automated Micro-deposits in Sandbox, see <a href="https://plaid.com/docs/auth/coverage/testing#">Auth full coverage testing</a>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/api/sandbox/#sandboxitemset_verification_status" /></remarks>
	public Task<Sandbox.SandboxItemSetVerificationStatusResponse> SandboxItemSetVerificationStatusAsync(Sandbox.SandboxItemSetVerificationStatusRequest request) =>
		PostAsync("/sandbox/item/set_verification_status", request)
			.ParseResponseAsync<Sandbox.SandboxItemSetVerificationStatusResponse>();

	/// <summary>
	/// <para>Use the <c>/sandbox/bank_transfer/simulate</c> endpoint to simulate a bank transfer event in the Sandbox environment.  Note that while an event will be simulated and will appear when using endpoints such as <c>/bank_transfer/event/sync</c> or <c>/bank_transfer/event/list</c>, no transactions will actually take place and funds will not move between accounts, even within the Sandbox.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/api/sandbox/#sandboxbank_transfersimulate" /></remarks>
	public Task<Sandbox.SandboxBankTransferSimulateResponse> SandboxBankTransferSimulateAsync(Sandbox.SandboxBankTransferSimulateRequest request) =>
		PostAsync("/sandbox/bank_transfer/simulate", request)
			.ParseResponseAsync<Sandbox.SandboxBankTransferSimulateResponse>();

	/// <summary>
	/// <para>Use the <c>/sandbox/transfer/simulate</c> endpoint to simulate a transfer event in the Sandbox environment.  Note that while an event will be simulated and will appear when using endpoints such as <c>/transfer/event/sync</c> or <c>/transfer/event/list</c>, no transactions will actually take place and funds will not move between accounts, even within the Sandbox.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/transfer/reference#sandboxtransfersimulate" /></remarks>
	public Task<Sandbox.SandboxTransferSimulateResponse> SandboxTransferSimulateAsync(Sandbox.SandboxTransferSimulateRequest request) =>
		PostAsync("/sandbox/transfer/simulate", request)
			.ParseResponseAsync<Sandbox.SandboxTransferSimulateResponse>();

	/// <summary>
	/// <para>Use the <c>/sandbox/bank_transfer/fire_webhook</c> endpoint to manually trigger a Bank Transfers webhook in the Sandbox environment.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/api/sandbox/#sandboxbank_transferfire_webhook" /></remarks>
	public Task<Sandbox.SandboxBankTransferFireWebhookResponse> SandboxBankTransferFireWebhookAsync(Sandbox.SandboxBankTransferFireWebhookRequest request) =>
		PostAsync("/sandbox/bank_transfer/fire_webhook", request)
			.ParseResponseAsync<Sandbox.SandboxBankTransferFireWebhookResponse>();

	/// <summary>
	/// <para>Use the <c>/sandbox/income/fire_webhook</c> endpoint to manually trigger an Income webhook in the Sandbox environment.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/api/sandbox/#sandboxincomefire_webhook" /></remarks>
	public Task<Sandbox.SandboxIncomeFireWebhookResponse> SandboxIncomeFireWebhookAsync(Sandbox.SandboxIncomeFireWebhookRequest request) =>
		PostAsync("/sandbox/income/fire_webhook", request)
			.ParseResponseAsync<Sandbox.SandboxIncomeFireWebhookResponse>();

	/// <summary>
	/// <para>Save the selected accounts when connecting to the Platypus Oauth institution</para>
	/// </summary>
	public Task<Sandbox.SandboxOauthSelectAccountsResponse> SandboxOauthSelectAccountsAsync(Sandbox.SandboxOauthSelectAccountsRequest request) =>
		PostAsync("/sandbox/oauth/select_accounts", request)
			.ParseResponseAsync<Sandbox.SandboxOauthSelectAccountsResponse>();
}