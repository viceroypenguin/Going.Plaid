namespace Going.Plaid.Entity;

/// <summary>
/// <para>Largest number of days between sequential transactions per calendar month</para>
/// </summary>
public record BaseReportLongestGapInsights
{
	/// <summary>
	/// <para>The start date of this time period.</para>
	/// <para>The date will be returned in an ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateOnly? StartDate { get; init; } = default!;

	/// <summary>
	/// <para>The end date of this time period.</para>
	/// <para>The date will be returned in an ISO 8601 format (YYYY-MM-DD).</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateOnly? EndDate { get; init; } = default!;

	/// <summary>
	/// <para>Largest number of days between sequential transactions for this time period.</para>
	/// </summary>
	[JsonPropertyName("days")]
	public int? Days { get; init; } = default!;

}
