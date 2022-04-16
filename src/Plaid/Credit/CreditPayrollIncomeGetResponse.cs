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
}