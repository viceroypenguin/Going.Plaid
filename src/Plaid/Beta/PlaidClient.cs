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
	/// <para>The <c>/transactions/rules/v1/create</c> endpoint creates transaction categorization rules.</para>
	/// <para>Rules will be applied on the Item's transactions returned in <c>/transactions/get</c> response.</para>
	/// <para>The product is currently in beta. To request access, contact transactions-feedback@plaid.com.</para>
	/// </summary>
	public Task<Beta.TransactionsRulesCreateResponse> BetaTransactionsRulesV1CreateAsync(Beta.TransactionsRulesCreateRequest request) =>
		PostAsync("/beta/transactions/rules/v1/create", request)
			.ParseResponseAsync<Beta.TransactionsRulesCreateResponse>();

	/// <summary>
	/// <para>The <c>/transactions/rules/v1/list</c> returns a list of transaction rules created for the Item associated with the access token.</para>
	/// </summary>
	public Task<Beta.TransactionsRulesListResponse> BetaTransactionsRulesV1ListAsync(Beta.TransactionsRulesListRequest request) =>
		PostAsync("/beta/transactions/rules/v1/list", request)
			.ParseResponseAsync<Beta.TransactionsRulesListResponse>();

	/// <summary>
	/// <para>The <c>/transactions/rules/v1/remove</c> endpoint is used to remove a transaction rule.</para>
	/// </summary>
	public Task<Beta.TransactionsRulesRemoveResponse> BetaTransactionsRulesV1RemoveAsync(Beta.TransactionsRulesRemoveRequest request) =>
		PostAsync("/beta/transactions/rules/v1/remove", request)
			.ParseResponseAsync<Beta.TransactionsRulesRemoveResponse>();
}