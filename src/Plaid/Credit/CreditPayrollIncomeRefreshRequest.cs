namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditPayrollIncomeRefreshRequest defines the request schema for <c>/credit/payroll_income/refresh</c></para>
/// </summary>
public partial class CreditPayrollIncomeRefreshRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; set; } = default!;

	/// <summary>
	/// <para>An optional object for <c>/credit/payroll_income/refresh</c> request options.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.CreditPayrollIncomeRefreshRequestOptions Options { get; set; } = default!;
}