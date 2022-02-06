namespace Going.Plaid.Entity;

/// <summary>
/// <para>The verified fields from a paystub verification. All fields are provided as reported on the paystub.</para>
/// </summary>
public record IncomeSummary
{
	/// <summary>
	/// <para>The name of the employer, as reported on the paystub.</para>
	/// </summary>
	[JsonPropertyName("employer_name")]
	public Entity.EmployerIncomeSummaryFieldString EmployerName { get; init; } = default!;

	/// <summary>
	/// <para>The name of the employee, as reported on the paystub.</para>
	/// </summary>
	[JsonPropertyName("employee_name")]
	public Entity.EmployeeIncomeSummaryFieldString EmployeeName { get; init; } = default!;

	/// <summary>
	/// <para>Year-to-date pre-tax earnings, as reported on the paystub.</para>
	/// </summary>
	[JsonPropertyName("ytd_gross_income")]
	public Entity.YtdGrossIncomeSummaryFieldNumber YtdGrossIncome { get; init; } = default!;

	/// <summary>
	/// <para>Year-to-date earnings after any tax withholdings, benefit payments or deductions, as reported on the paystub.</para>
	/// </summary>
	[JsonPropertyName("ytd_net_income")]
	public Entity.YtdNetIncomeSummaryFieldNumber YtdNetIncome { get; init; } = default!;

	/// <summary>
	/// <para>The frequency of the pay period.</para>
	/// </summary>
	[JsonPropertyName("pay_frequency")]
	public Entity.PayFrequency? PayFrequency { get; init; } = default!;

	/// <summary>
	/// <para>The employee's estimated annual salary, as derived from information reported on the paystub.</para>
	/// </summary>
	[JsonPropertyName("projected_wage")]
	public Entity.ProjectedIncomeSummaryFieldNumber ProjectedWage { get; init; } = default!;

	/// <summary>
	/// <para>Information about the matched direct deposit transaction used to verify a user's payroll information.</para>
	/// </summary>
	[JsonPropertyName("verified_transaction")]
	public Entity.TransactionData? VerifiedTransaction { get; init; } = default!;
}