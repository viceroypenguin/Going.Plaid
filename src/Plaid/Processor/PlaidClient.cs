namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The <c>/processor/auth/get</c> endpoint returns the bank account and bank identification number (such as the routing number, for US accounts), for a checking or savings account that's associated with a given <c>processor_token</c>. The endpoint also returns high-level account data and balances when available.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/api/processors/#processorauthget" /></remarks>
	public Task<Processor.ProcessorAuthGetResponse> ProcessorAuthGetAsync(Processor.ProcessorAuthGetRequest request) =>
		PostAsync("/processor/auth/get", request)
			.ParseResponseAsync<Processor.ProcessorAuthGetResponse>();

	/// <summary>
	/// <para>Use the <c>/processor/bank_transfer/create</c> endpoint to initiate a new bank transfer as a processor</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/api/processors/#bank_transfercreate" /></remarks>
	public Task<Processor.ProcessorBankTransferCreateResponse> ProcessorBankTransferCreateAsync(Processor.ProcessorBankTransferCreateRequest request) =>
		PostAsync("/processor/bank_transfer/create", request)
			.ParseResponseAsync<Processor.ProcessorBankTransferCreateResponse>();

	/// <summary>
	/// <para>The <c>/processor/identity/get</c> endpoint allows you to retrieve various account holder information on file with the financial institution, including names, emails, phone numbers, and addresses.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/api/processors/#processoridentityget" /></remarks>
	public Task<Processor.ProcessorIdentityGetResponse> ProcessorIdentityGetAsync(Processor.ProcessorIdentityGetRequest request) =>
		PostAsync("/processor/identity/get", request)
			.ParseResponseAsync<Processor.ProcessorIdentityGetResponse>();

	/// <summary>
	/// <para>The <c>/processor/balance/get</c> endpoint returns the real-time balance for each of an Item's accounts. While other endpoints may return a balance object, only <c>/processor/balance/get</c> forces the available and current balance fields to be refreshed rather than cached.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/api/processors/#processorbalanceget" /></remarks>
	public Task<Processor.ProcessorBalanceGetResponse> ProcessorBalanceGetAsync(Processor.ProcessorBalanceGetRequest request) =>
		PostAsync("/processor/balance/get", request)
			.ParseResponseAsync<Processor.ProcessorBalanceGetResponse>();

	/// <summary>
	/// <para>Used to create a token suitable for sending to one of Plaid's partners to enable integrations. Note that Stripe partnerships use bank account tokens instead; see <c>/processor/stripe/bank_account_token/create</c> for creating tokens for use with Stripe integrations.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/api/processors/#processortokencreate" /></remarks>
	public Task<Processor.ProcessorTokenCreateResponse> ProcessorTokenCreateAsync(Processor.ProcessorTokenCreateRequest request) =>
		PostAsync("/processor/token/create", request)
			.ParseResponseAsync<Processor.ProcessorTokenCreateResponse>();

	/// <summary>
	/// <para>Used to create a token suitable for sending to Stripe to enable Plaid-Stripe integrations. For a detailed guide on integrating Stripe, see <a href="https://plaid.com/docs/auth/partnerships/stripe/">Add Stripe to your app</a>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/api/processors/#processorstripebank_account_tokencreate" /></remarks>
	public Task<Processor.ProcessorStripeBankAccountTokenCreateResponse> ProcessorStripeBankAccountTokenCreateAsync(Processor.ProcessorStripeBankAccountTokenCreateRequest request) =>
		PostAsync("/processor/stripe/bank_account_token/create", request)
			.ParseResponseAsync<Processor.ProcessorStripeBankAccountTokenCreateResponse>();

	/// <summary>
	/// <para>Used to create a token suitable for sending to Apex to enable Plaid-Apex integrations.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/none/" /></remarks>
	public Task<Processor.ProcessorTokenCreateResponse> ProcessorApexProcessorTokenCreateAsync(Processor.ProcessorApexProcessorTokenCreateRequest request) =>
		PostAsync("/processor/apex/processor_token/create", request)
			.ParseResponseAsync<Processor.ProcessorTokenCreateResponse>();
}