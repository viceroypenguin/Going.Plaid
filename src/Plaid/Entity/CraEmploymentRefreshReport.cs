namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing an Employment Refresh Report.</para>
/// </summary>
public record CraEmploymentRefreshReport
{
	/// <summary>
	/// <para>The date and time when the Employment Refresh Report was created, in ISO 8601 format (e.g. "2018-04-12T03:32:11Z").</para>
	/// </summary>
	[JsonPropertyName("generated_time")]
	public DateTimeOffset GeneratedTime { get; init; } = default!;

	/// <summary>
	/// <para>The number of days of transaction history that the Employment Refresh Report covers.</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public decimal DaysRequested { get; init; } = default!;

	/// <summary>
	/// <para>Data returned by Plaid about each of the Items included in the Employment Refresh Report.</para>
	/// </summary>
	[JsonPropertyName("items")]
	public IReadOnlyList<Entity.CraEmploymentRefreshReportItem> Items { get; init; } = default!;

}
