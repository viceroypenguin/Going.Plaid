namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing a Base Report</para>
/// </summary>
public record BaseReport
{
	/// <summary>
	/// <para>A unique ID identifying an Base Report. Like all Plaid identifiers, this ID is case sensitive.</para>
	/// </summary>
	[JsonPropertyName("report_id")]
	public string ReportId { get; init; } = default!;

	/// <summary>
	/// <para>The date and time when the Base Report was created, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (e.g. "2018-04-12T03:32:11Z").</para>
	/// </summary>
	[JsonPropertyName("date_generated")]
	public DateTimeOffset DateGenerated { get; init; } = default!;

	/// <summary>
	/// <para>The number of days of transaction history requested.</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public decimal DaysRequested { get; init; } = default!;

	/// <summary>
	/// <para>Client-generated identifier, which can be used by lenders to track loan applications.</para>
	/// </summary>
	[JsonPropertyName("client_report_id")]
	public string? ClientReportId { get; init; } = default!;

	/// <summary>
	/// <para>Data returned by Plaid about each of the Items included in the Base Report.</para>
	/// </summary>
	[JsonPropertyName("items")]
	public IReadOnlyList<Entity.BaseReportItem> Items { get; init; } = default!;

}
