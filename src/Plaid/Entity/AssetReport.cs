namespace Going.Plaid.Entity;

/// <summary>
/// <para>An object representing an Asset Report</para>
/// </summary>
public record AssetReport
{
	/// <summary>
	/// <para>A unique ID identifying an Asset Report. Like all Plaid identifiers, this ID is case sensitive.</para>
	/// </summary>
	[JsonPropertyName("asset_report_id")]
	public string AssetReportId { get; init; } = default!;

	/// <summary>
	/// <para>An identifier you determine and submit for the Asset Report.</para>
	/// </summary>
	[JsonPropertyName("client_report_id")]
	public string? ClientReportId { get; init; } = default!;

	/// <summary>
	/// <para>The date and time when the Asset Report was created, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> format (e.g. "2018-04-12T03:32:11Z").</para>
	/// </summary>
	[JsonPropertyName("date_generated")]
	public DateTimeOffset DateGenerated { get; init; } = default!;

	/// <summary>
	/// <para>The duration of transaction history you requested</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public decimal DaysRequested { get; init; } = default!;

	/// <summary>
	/// <para>The user object allows you to provide additional information about the user to be appended to the Asset Report. All fields are optional. The <c>first_name</c>, <c>last_name</c>, and <c>ssn</c> fields are required if you would like the Report to be eligible for Fannie Mae’s Day 1 Certainty™ program.</para>
	/// </summary>
	[JsonPropertyName("user")]
	public Entity.AssetReportUser User { get; init; } = default!;

	/// <summary>
	/// <para>Data returned by Plaid about each of the Items included in the Asset Report.</para>
	/// </summary>
	[JsonPropertyName("items")]
	public IReadOnlyList<Entity.AssetReportItem> Items { get; init; } = default!;
}