namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing the rate at which an individual is paid.</para>
/// </summary>
public record PayrollIncomeRateOfPay
{
	/// <summary>
	/// <para>The rate at which an employee is paid.</para>
	/// </summary>
	[JsonPropertyName("pay_rate")]
	public string? PayRate { get; init; } = default!;

	/// <summary>
	/// <para>The amount at which an employee is paid.</para>
	/// </summary>
	[JsonPropertyName("pay_amount")]
	public decimal? PayAmount { get; init; } = default!;
}