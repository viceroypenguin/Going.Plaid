namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/processor/auth/get</c> endpoint returns the bank account and bank identification number (such as the routing number, for US accounts), for a checking or savings account that''s associated with a given <c>processor_token</c>. The endpoint also returns high-level account data and balances when available.</para>
	/// <para>Versioning note: API versions 2019-05-29 and earlier use a different schema for the <c>numbers</c> object returned by this endpoint. For details, see <a href="https://plaid.com/docs/api/versioning/#version-2020-09-14">Plaid API versioning</a>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processors/#processorauthget" /></remarks>
	public Task<Processor.ProcessorAuthGetResponse> ProcessorAuthGetAsync(Processor.ProcessorAuthGetRequest request) =>
		PostAsync("/processor/auth/get", request)
			.ParseResponseAsync<Processor.ProcessorAuthGetResponse>();

	/// <summary>
	/// <para>Use <c>/processor/signal/evaluate</c> to evaluate a planned ACH transaction as a processor to get a return risk assessment (such as a risk score and risk tier) and additional risk signals.</para>
	/// <para>In order to obtain a valid score for an ACH transaction, Plaid must have an access token for the account, and the Item must be healthy (receiving product updates) or have recently been in a healthy state. If the transaction does not meet eligibility requirements, an error will be returned corresponding to the underlying cause. If <c>/processor/signal/evaluate</c> is called on the same transaction multiple times within a 24-hour period, cached results may be returned. For more information please refer to our error documentation on <a href="https://plaid.com/docs/errors/item/">item errors</a> and <a href="https://plaid.com/docs/link/update-mode/">Link in Update Mode</a>.</para>
	/// <para>Note: This request may take some time to complete if Signal is being added to an existing Item. This is because Plaid must communicate directly with the institution when retrieving the data for the first time.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processors/#processorsignalevaluate" /></remarks>
	public Task<Processor.ProcessorSignalEvaluateResponse> ProcessorSignalEvaluateAsync(Processor.ProcessorSignalEvaluateRequest request) =>
		PostAsync("/processor/signal/evaluate", request)
			.ParseResponseAsync<Processor.ProcessorSignalEvaluateResponse>();

	/// <summary>
	/// <para>After calling <c>/processor/signal/evaluate</c>, call <c>/processor/signal/decision/report</c> to report whether the transaction was initiated. This endpoint will return an <a href="https://plaid.com/docs/errors/invalid-request/#invalid_field"><c>INVALID_FIELD</c></a> error if called a second time with a different value for <c>initiated</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processors/#processorsignaldecisionreport" /></remarks>
	public Task<Processor.ProcessorSignalDecisionReportResponse> ProcessorSignalDecisionReportAsync(Processor.ProcessorSignalDecisionReportRequest request) =>
		PostAsync("/processor/signal/decision/report", request)
			.ParseResponseAsync<Processor.ProcessorSignalDecisionReportResponse>();

	/// <summary>
	/// <para>Call the <c>/processor/signal/return/report</c> endpoint to report a returned transaction that was previously sent to the <c>/processor/signal/evaluate</c> endpoint. Your feedback will be used by the model to incorporate the latest risk trend in your portfolio.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processors/#processorsignalreturnreport" /></remarks>
	public Task<Processor.ProcessorSignalReturnReportResponse> ProcessorSignalReturnReportAsync(Processor.ProcessorSignalReturnReportRequest request) =>
		PostAsync("/processor/signal/return/report", request)
			.ParseResponseAsync<Processor.ProcessorSignalReturnReportResponse>();

	/// <summary>
	/// <para>Use the <c>/processor/bank_transfer/create</c> endpoint to initiate a new bank transfer as a processor</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processors/#bank_transfercreate" /></remarks>
	public Task<Processor.ProcessorBankTransferCreateResponse> ProcessorBankTransferCreateAsync(Processor.ProcessorBankTransferCreateRequest request) =>
		PostAsync("/processor/bank_transfer/create", request)
			.ParseResponseAsync<Processor.ProcessorBankTransferCreateResponse>();

	/// <summary>
	/// <para>The <c>/processor/identity/get</c> endpoint allows you to retrieve various account holder information on file with the financial institution, including names, emails, phone numbers, and addresses.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processors/#processoridentityget" /></remarks>
	public Task<Processor.ProcessorIdentityGetResponse> ProcessorIdentityGetAsync(Processor.ProcessorIdentityGetRequest request) =>
		PostAsync("/processor/identity/get", request)
			.ParseResponseAsync<Processor.ProcessorIdentityGetResponse>();

	/// <summary>
	/// <para>The <c>/processor/balance/get</c> endpoint returns the real-time balance for each of an Item's accounts. While other endpoints may return a balance object, only <c>/processor/balance/get</c> forces the available and current balance fields to be refreshed rather than cached.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processors/#processorbalanceget" /></remarks>
	public Task<Processor.ProcessorBalanceGetResponse> ProcessorBalanceGetAsync(Processor.ProcessorBalanceGetRequest request) =>
		PostAsync("/processor/balance/get", request)
			.ParseResponseAsync<Processor.ProcessorBalanceGetResponse>();

	/// <summary>
	/// <para>Used to create a token suitable for sending to one of Plaid's partners to enable integrations. Note that Stripe partnerships use bank account tokens instead; see <c>/processor/stripe/bank_account_token/create</c> for creating tokens for use with Stripe integrations. Once created, a processor token for a given Item cannot be modified or updated. If the account must be linked to a new or different partner resource, create a new Item by having the user go through the Link flow again; a new processor token can then be created from the new <c>access_token</c>. Processor tokens can also be revoked, using <c>/item/remove</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processors/#processortokencreate" /></remarks>
	public Task<Processor.ProcessorTokenCreateResponse> ProcessorTokenCreateAsync(Processor.ProcessorTokenCreateRequest request) =>
		PostAsync("/processor/token/create", request)
			.ParseResponseAsync<Processor.ProcessorTokenCreateResponse>();

	/// <summary>
	/// <para>Used to create a token suitable for sending to Stripe to enable Plaid-Stripe integrations. For a detailed guide on integrating Stripe, see <a href="https://plaid.com/docs/auth/partnerships/stripe/">Add Stripe to your app</a>.</para>
	/// <para>Note that the Stripe bank account token is a one-time use token. To store bank account information for later use, you can use a Stripe customer object and create an associated bank account from the token, or you can use a Stripe Custom account and create an associated external bank account from the token. This bank account information should work indefinitely, unless the user's bank account information changes or they revoke Plaid's permissions to access their account. Stripe bank account information cannot be modified once the bank account token has been created. If you ever need to change the bank account details used by Stripe for a specific customer, have the user go through Link again and create a new bank account token from the new <c>access_token</c>.</para>
	/// <para>Bank account tokens can also be revoked, using <c>/item/remove</c>.'</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/processors/#processorstripebank_account_tokencreate" /></remarks>
	public Task<Processor.ProcessorStripeBankAccountTokenCreateResponse> ProcessorStripeBankAccountTokenCreateAsync(Processor.ProcessorStripeBankAccountTokenCreateRequest request) =>
		PostAsync("/processor/stripe/bank_account_token/create", request)
			.ParseResponseAsync<Processor.ProcessorStripeBankAccountTokenCreateResponse>();

	/// <summary>
	/// <para>Used to create a token suitable for sending to Apex to enable Plaid-Apex integrations.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/none/" /></remarks>
	public Task<Processor.ProcessorTokenCreateResponse> ProcessorApexProcessorTokenCreateAsync(Processor.ProcessorApexProcessorTokenCreateRequest request) =>
		PostAsync("/processor/apex/processor_token/create", request)
			.ParseResponseAsync<Processor.ProcessorTokenCreateResponse>();
}