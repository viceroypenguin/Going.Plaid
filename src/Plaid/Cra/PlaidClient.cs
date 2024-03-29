namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para>This endpoint allows the customer to retrieve a Base Report. Customers should pass in the <c>user_token</c> created in <c>/link/token/create</c>.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/none/" /></remarks>
	public Task<Cra.BaseReportGetResponse> CraBaseReportGetAsync(Cra.BaseReportGetRequest request) =>
		PostAsync("/cra/base_report/get", request)
			.ParseResponseAsync<Cra.BaseReportGetResponse>();

	/// <summary>
	/// <para>This endpoint allows the customer to create a Base Report by passing in a user token. The Base Report will be generated based on the most recently linked item from the user token.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/none/" /></remarks>
	public Task<Cra.BaseReportCreateResponse> CraBaseReportCreateAsync(Cra.BaseReportCreateRequest request) =>
		PostAsync("/cra/base_report/create", request)
			.ParseResponseAsync<Cra.BaseReportCreateResponse>();

	/// <summary>
	/// <para><c>/cra/bank_income/get</c> returns the bank income report(s) for a specified user.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#crabank_incomeget" /></remarks>
	public Task<Cra.CraBankIncomeGetResponse> CraBankIncomeGetAsync(Cra.CraBankIncomeGetRequest request) =>
		PostAsync("/cra/bank_income/get", request)
			.ParseResponseAsync<Cra.CraBankIncomeGetResponse>();

	/// <summary>
	/// <para><c>/cra/bank_income/create</c> creates a CRA report for income verification</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#crabank_incomecreate" /></remarks>
	public Task<Cra.CraBankIncomeCreateResponse> CraBankIncomeCreateAsync(Cra.CraBankIncomeCreateRequest request) =>
		PostAsync("/cra/bank_income/create", request)
			.ParseResponseAsync<Cra.CraBankIncomeCreateResponse>();

	/// <summary>
	/// <para><c>/cra/partner_insights/get</c> returns cash flow insights for a specified user.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#crapartner_insightsget" /></remarks>
	public Task<Cra.CraPartnerInsightsGetResponse> CraPartnerInsightsGetAsync(Cra.CraPartnerInsightsGetRequest request) =>
		PostAsync("/cra/partner_insights/get", request)
			.ParseResponseAsync<Cra.CraPartnerInsightsGetResponse>();

}
