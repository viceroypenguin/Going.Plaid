namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for use with the Statements product.</para>
/// </summary>
public class LinkTokenCreateRequestStatements
{
	/// <summary>
	/// <para>The start date for statements, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> “YYYY-MM-DD” format, e.g. "2020-10-30". If no value is provided, this will default to 3 months prior to the current date.</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateOnly? StartDate { get; set; } = default!;

	/// <summary>
	/// <para>The end date for statements, in <a href="https://wikipedia.org/wiki/ISO_8601">ISO 8601</a> “YYYY-MM-DD” format, e.g. "2020-10-30". If no value is provided, this will default to the current date. You can request up to two years of data.</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateOnly? EndDate { get; set; } = default!;

}
