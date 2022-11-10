namespace Going.Plaid.Entity;

/// <summary>
/// <para>Requested payment (i.e. receiving money) limits for the end customer.</para>
/// </summary>
public class PaymentLimits
{
	/// <summary>
	/// <para>Average payment amount, in dollars.</para>
	/// </summary>
	[JsonPropertyName("average_amount")]
	public int AverageAmount { get; set; } = default!;

	/// <summary>
	/// <para>Maximum payment amount, in dollars.</para>
	/// </summary>
	[JsonPropertyName("maximum_amount")]
	public int MaximumAmount { get; set; } = default!;

	/// <summary>
	/// <para>Monthly payment amount, in dollars.</para>
	/// </summary>
	[JsonPropertyName("monthly_amount")]
	public int MonthlyAmount { get; set; } = default!;
}