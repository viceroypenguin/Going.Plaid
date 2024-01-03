namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing a breakdown of the different income types on the paystub.</para>
/// </summary>
public record IncomeBreakdown
{
	/// <summary>
	/// <para>The type of income. Possible values include:</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.IncomeBreakdownType? Type { get; init; } = default!;

	/// <summary>
	/// <para>The hourly rate at which the income is paid.</para>
	/// </summary>
	[JsonPropertyName("rate")]
	public decimal? Rate { get; init; } = default!;

	/// <summary>
	/// <para>The number of hours logged for this income for this pay period.</para>
	/// </summary>
	[JsonPropertyName("hours")]
	public decimal? Hours { get; init; } = default!;

	/// <summary>
	/// <para>The total pay for this pay period.</para>
	/// </summary>
	[JsonPropertyName("total")]
	public decimal? Total { get; init; } = default!;

}
