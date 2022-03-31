namespace Going.Plaid.Credit;

/// <summary>
/// <para>Defines the response body for <c>/credit/payroll_income/get</c>.</para>
/// </summary>
public record CreditPayrollIncomeGetResponse : ResponseBase
{
	/// <summary>
	/// <para>The unique identifier associated with the payroll income response.</para>
	/// </summary>
	[JsonPropertyName("payroll_income_id")]
	public string PayrollIncomeId { get; init; } = default!;

	/// <summary>
	/// <para>Array of payroll items.</para>
	/// </summary>
	[JsonPropertyName("items")]
	public IReadOnlyList<Entity.PayrollItem> Items { get; init; } = default!;
}
