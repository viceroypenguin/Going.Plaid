namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>The '/beta/transactions/v1/enhance' endpoint enriches raw transaction data provided directly by clients.</para>
	/// <para>The product is currently in beta.</para>
	/// </summary>
	public Task<Beta.TransactionsEnhanceGetResponse> BetaTransactionsV1EnhanceAsync(Beta.TransactionsEnhanceGetRequest request) =>
		PostAsync("/beta/transactions/v1/enhance", request)
			.ParseResponseAsync<Beta.TransactionsEnhanceGetResponse>();

	/// <summary>
	/// <para>The <c>/transactions/rules/create</c> endpoint creates transaction categorization rules.</para>
	/// <para>Rules will be applied on the Item's transactions returned in <c>/transactions/get</c> response.</para>
	/// <para>The product is currently in beta. To request access, contact transactions-feedback@plaid.com.</para>
	/// </summary>
	public Task<Beta.TransactionsRulesCreateResponse> BetaTransactionsRulesCreateAsync(Beta.TransactionsRulesCreateRequest request) =>
		PostAsync("/beta/transactions/rules/create", request)
			.ParseResponseAsync<Beta.TransactionsRulesCreateResponse>();

	/// <summary>
	/// <para>The <c>/transactions/rules/list</c> returns a list of transaction rules created for the Item associated with the access token.</para>
	/// </summary>
	public Task<Beta.TransactionsRulesListResponse> BetaTransactionsRulesListAsync(Beta.TransactionsRulesListRequest request) =>
		PostAsync("/beta/transactions/rules/list", request)
			.ParseResponseAsync<Beta.TransactionsRulesListResponse>();

	/// <summary>
	/// <para>The <c>/transactions/rules/remove</c> endpoint is used to remove a transaction rule.</para>
	/// </summary>
	public Task<Beta.TransactionsRulesRemoveResponse> BetaTransactionsRulesRemoveAsync(Beta.TransactionsRulesRemoveRequest request) =>
		PostAsync("/beta/transactions/rules/remove", request)
			.ParseResponseAsync<Beta.TransactionsRulesRemoveResponse>();
}