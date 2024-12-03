namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about the pay period.</para>
/// </summary>
public record PayPeriodDetails
{
	/// <summary>
	/// <para>The amount of the paycheck.</para>
	/// </summary>
	[JsonPropertyName("check_amount")]
	public decimal? CheckAmount { get; init; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("distribution_breakdown")]
	public IReadOnlyList<Entity.DistributionBreakdown>? DistributionBreakdown { get; init; } = default!;

	/// <summary>
	/// <para>The pay period end date, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format: "yyyy-mm-dd".</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateOnly? EndDate { get; init; } = default!;

	/// <summary>
	/// <para>Total earnings before tax/deductions.</para>
	/// </summary>
	[JsonPropertyName("gross_earnings")]
	public decimal? GrossEarnings { get; init; } = default!;

	/// <summary>
	/// <para>The date on which the paystub was issued, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format ("yyyy-mm-dd").</para>
	/// </summary>
	[JsonPropertyName("pay_date")]
	public DateOnly? PayDate { get; init; } = default!;

	/// <summary>
	/// <para>The frequency at which an individual is paid.</para>
	/// </summary>
	[JsonPropertyName("pay_frequency")]
	public Entity.PayPeriodDetailsPayFrequency? PayFrequency { get; init; } = default!;

	/// <summary>
	/// <para>The date on which the paystub was issued, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format ("yyyy-mm-dd").</para>
	/// </summary>
	[JsonPropertyName("pay_day")]
	[Obsolete]
	public DateOnly? PayDay { get; init; } = default!;

	/// <summary>
	/// <para>The pay period start date, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format: "yyyy-mm-dd".</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateOnly? StartDate { get; init; } = default!;

}
