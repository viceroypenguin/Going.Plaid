namespace Going.Plaid.Entity;

/// <summary>
/// <para>Monthly summary of transactions within a specific time period, showing aggregated amounts.</para>
/// </summary>
public record MonthlySummary
{
	/// <summary>
	/// <para>The start date of the month for the given report time window. Will be provided in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateOnly? StartDate { get; init; } = default!;

	/// <summary>
	/// <para>The end date of the month for the given report time window. Will be provided in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateOnly? EndDate { get; init; } = default!;

	/// <summary>
	/// <para>A monetary amount with its associated currency information, supporting both official and unofficial currency codes.</para>
	/// </summary>
	[JsonPropertyName("total_amount")]
	public Entity.AmountWithCurrency? TotalAmount { get; init; } = default!;

}
