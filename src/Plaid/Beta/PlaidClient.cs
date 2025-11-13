namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para><c>/credit/bank_employment/get</c> returns the employment report(s) derived from bank transaction data for a specified user.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#creditbank_employmentget" /></remarks>
	public Task<Beta.CreditBankEmploymentGetResponse> BetaCreditV1BankEmploymentGetAsync(Beta.CreditBankEmploymentGetRequest request) =>
		PostAsync("/beta/credit/v1/bank_employment/get", request)
			.ParseResponseAsync<Beta.CreditBankEmploymentGetResponse>();

	/// <summary>
	/// <para>The <c>/beta/transactions/v1/enhance</c> endpoint enriches raw transaction data provided directly by clients.</para>
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

	/// <summary>
	/// <para>The <c>/beta/transactions/user_insights/v1/get</c> gets user insights for clients who have enriched data with <c>/transactions/enrich</c>.</para>
	/// <para>The product is currently in beta.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/enrich/#userinsightsget" /></remarks>
	public Task<Beta.TransactionsUserInsightsGetResponse> BetaTransactionsUserInsightsV1GetAsync(Beta.TransactionsUserInsightsGetRequest request) =>
		PostAsync("/beta/transactions/user_insights/v1/get", request)
			.ParseResponseAsync<Beta.TransactionsUserInsightsGetResponse>();

	/// <summary>
	/// <para>The <c>/beta/ewa_report/v1/get</c> endpoint provides an Earned Wage Access (EWA) score that quantifies the delinquency risk associated with a given item. The score is derived from a combination of cashflow patterns and network-based behavioral features.</para>
	/// <para>The response returns a list of EWA scores, where each score corresponds to a potential advance amount range. These scores estimate the likelihood of repayment for advances within that range.</para>
	/// <para>Score range: 1–99</para>
	/// <para>Interpretation: Higher scores indicate a greater likelihood of repayment.</para>
	/// <para>This endpoint enables clients to assess repayment risk and make data-driven decisions when determining eligibility or limits for earned wage advances.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/beta/#betaewareportv1get" /></remarks>
	public Task<Beta.BetaEwaReportV1GetResponse> BetaEwaReportV1GetAsync(Beta.BetaEwaReportV1GetRequest request) =>
		PostAsync("/beta/ewa_report/v1/get", request)
			.ParseResponseAsync<Beta.BetaEwaReportV1GetResponse>();

	/// <summary>
	/// <para>The <c>/beta/partner/customer/v1/create</c> endpoint creates a new end customer record. You can provide as much information as you have available. If any required information is missing for the products you intend to use, it will be listed in the <c>requirements_due</c> field of the response.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/partner/#partnercustomercreate" /></remarks>
	public Task<Beta.BetaPartnerCustomerV1CreateResponse> BetaPartnerCustomerV1CreateAsync(Beta.BetaPartnerCustomerV1CreateRequest request) =>
		PostAsync("/beta/partner/customer/v1/create", request)
			.ParseResponseAsync<Beta.BetaPartnerCustomerV1CreateResponse>();

	/// <summary>
	/// <para>The <c>/beta/partner/customer/v1/get</c> endpoint is used by reseller partners to retrieve data about a single end customer.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/partner/#partnercustomerget" /></remarks>
	public Task<Beta.BetaPartnerCustomerV1GetResponse> BetaPartnerCustomerV1GetAsync(Beta.BetaPartnerCustomerV1GetRequest request) =>
		PostAsync("/beta/partner/customer/v1/get", request)
			.ParseResponseAsync<Beta.BetaPartnerCustomerV1GetResponse>();

	/// <summary>
	/// <para>The <c>/beta/partner/customer/v1/update</c> endpoint updates an existing end customer record.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/partner/#partnercustomercreate" /></remarks>
	public Task<Beta.BetaPartnerCustomerV1UpdateResponse> BetaPartnerCustomerV1UpdateAsync(Beta.BetaPartnerCustomerV1UpdateRequest request) =>
		PostAsync("/beta/partner/customer/v1/update", request)
			.ParseResponseAsync<Beta.BetaPartnerCustomerV1UpdateResponse>();

	/// <summary>
	/// <para>The <c>/beta/partner/customer/v1/enable</c> endpoint is used by reseller partners to enable an end customer in the full Production environment.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/partner/#partnercustomerenable" /></remarks>
	public Task<Beta.BetaPartnerCustomerV1EnableResponse> BetaPartnerCustomerV1EnableAsync(Beta.BetaPartnerCustomerV1EnableRequest request) =>
		PostAsync("/beta/partner/customer/v1/enable", request)
			.ParseResponseAsync<Beta.BetaPartnerCustomerV1EnableResponse>();

}
