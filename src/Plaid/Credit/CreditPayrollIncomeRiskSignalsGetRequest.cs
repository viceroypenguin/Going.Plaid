namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditPayrollIncomeRiskSignalsGetRequest defines the request schema for <c>/credit/payroll_income/risk_signals/get</c></para>
/// </summary>
public partial class CreditPayrollIncomeRiskSignalsGetRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string? UserToken { get; set; } = default!;
}