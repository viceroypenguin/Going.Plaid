namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para><c>/credit/bank_income/get</c> returns the bank income report(s) for a specified user.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#creditbank_incomeget" /></remarks>
	public Task<Credit.CreditBankIncomeGetResponse> CreditBankIncomeGetAsync(Credit.CreditBankIncomeGetRequest request) =>
		PostAsync("/credit/bank_income/get", request)
			.ParseResponseAsync<Credit.CreditBankIncomeGetResponse>();
}