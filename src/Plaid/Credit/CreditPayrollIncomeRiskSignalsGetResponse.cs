namespace Going.Plaid.Credit;

/// <summary>
/// <para>CreditPayrollIncomeRiskSignalsGetRequest defines the response schema for <c>/credit/payroll_income/risk_signals/get</c></para>
/// </summary>
public record CreditPayrollIncomeRiskSignalsGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Array of payroll items.</para>
	/// </summary>
	[JsonPropertyName("items")]
	public IReadOnlyList<Entity.PayrollRiskSignalsItem> Items { get; init; } = default!;

}
