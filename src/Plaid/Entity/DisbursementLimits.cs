namespace Going.Plaid.Entity;

/// <summary>
/// <para>Requested disbursement (i.e. sending money) limits for the end customer.</para>
/// </summary>
public class DisbursementLimits
{
	/// <summary>
	/// <para>Average disbursement amount in a single transaction, in dollars.</para>
	/// </summary>
	[JsonPropertyName("average_amount")]
	public int AverageAmount { get; set; } = default!;

	/// <summary>
	/// <para>Maximum disbursement amount in a single transaction, in dollars.</para>
	/// </summary>
	[JsonPropertyName("maximum_amount")]
	public int MaximumAmount { get; set; } = default!;

	/// <summary>
	/// <para>Monthly disbursement amount, in dollars.</para>
	/// </summary>
	[JsonPropertyName("monthly_amount")]
	public int MonthlyAmount { get; set; } = default!;
}