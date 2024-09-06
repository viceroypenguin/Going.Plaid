namespace Going.Plaid.Statements;

/// <summary>
/// <para>StatementsRefreshRequest defines the request schema for <c>/statements/refresh</c></para>
/// </summary>
public partial class StatementsRefreshRequest : RequestBase
{
	/// <summary>
	/// <para>The start date for statements, in "YYYY-MM-DD" format, e.g. "2023-08-30". To determine whether a statement falls within the specified date range, Plaid will use the statement posted date. The statement posted date is typically either the last day of the statement period, or the following day.</para>
	/// </summary>
	[JsonPropertyName("start_date")]
	public DateOnly StartDate { get; set; } = default!;

	/// <summary>
	/// <para>The end date for statements, in "YYYY-MM-DD" format, e.g. "2023-10-30". You can request up to two years of data. To determine whether a statement falls within the specified date range, Plaid will use the statement posted date. The statement posted date is typically either the last day of the statement period, or the following day.</para>
	/// </summary>
	[JsonPropertyName("end_date")]
	public DateOnly EndDate { get; set; } = default!;

}
