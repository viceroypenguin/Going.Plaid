namespace Going.Plaid.Entity;

/// <summary>
/// <para>The number of credits or debits out of the account. This field will only added for depository accounts</para>
/// </summary>
public record BaseReportNumberFlowInsights
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
	/// <para>The number of credits or debits out of the account for this time period.</para>
	/// </summary>
	[JsonPropertyName("count")]
	public int? Count { get; init; } = default!;
}