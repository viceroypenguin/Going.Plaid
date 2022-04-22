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
}