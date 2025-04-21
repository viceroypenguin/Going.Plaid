namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing a VOE report.</para>
/// </summary>
public record CraVoeReport
{
	/// <summary>
	/// <para>The date and time when the VOE Report was created, in ISO 8601 format (e.g. "2018-04-12T03:32:11Z").</para>
	/// </summary>
	[JsonPropertyName("generated_time")]
	public DateTimeOffset GeneratedTime { get; init; } = default!;

	/// <summary>
	/// <para>The number of days of transaction history that the VOE Report covers.</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public decimal DaysRequested { get; init; } = default!;

	/// <summary>
	/// <para>Data returned by Plaid about each of the Items included in the VOE Report.</para>
	/// </summary>
	[JsonPropertyName("items")]
	public IReadOnlyList<Entity.CraVoeReportItem> Items { get; init; } = default!;

}
