namespace Going.Plaid.Credit;

/// <summary>
/// <para>Defines the response body for <c>/credit/payroll_income/get</c>.</para>
/// </summary>
public record CreditPayrollIncomeGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Array of payroll items.</para>
	/// </summary>
	[JsonPropertyName("items")]
	public IReadOnlyList<Entity.PayrollItem> Items { get; init; } = default!;

	/// <summary>
	/// <para>A token to reference what payroll data was returned from this endpoint</para>
	/// </summary>
	[JsonPropertyName("income_report_token")]
	public string IncomeReportToken { get; init; } = default!;
}