namespace Going.Plaid;

public sealed partial class PlaidClient
{
	/// <summary>
	/// <para><c>/employment/verification/get</c> returns a list of employments through a user payroll that was verified by an end user.</para>
	/// <para>This endpoint has been deprecated; new integrations should use <c>/credit/employment/get</c> instead.</para>
	/// </summary>
	/// <remarks><see href="https://plaid.com/docs/api/products/income/#employmentverificationget" /></remarks>
	public Task<Employment.EmploymentVerificationGetResponse> EmploymentVerificationGetAsync(Employment.EmploymentVerificationGetRequest request) =>
		PostAsync("/employment/verification/get", request)
			.ParseResponseAsync<Employment.EmploymentVerificationGetResponse>();
}