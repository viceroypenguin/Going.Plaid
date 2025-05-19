namespace Going.Plaid.CashflowReport;

/// <summary>
/// <para>CashflowReportGetRequest defines the request schema for <c>/cashflow_report/get</c></para>
/// </summary>
public partial class CashflowReportGetRequest : RequestBase
{
	/// <summary>
	/// <para>Number of days to retrieve transactions data for (1 to 730)</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int DaysRequested { get; set; } = default!;

	/// <summary>
	/// <para>Number of transactions to fetch per call</para>
	/// </summary>
	[JsonPropertyName("count")]
	public int? Count { get; set; } = default!;

	/// <summary>
	/// <para>The cursor value represents the last update requested. Pass in the empty string "" in the first call.</para>
	/// </summary>
	[JsonPropertyName("cursor")]
	public string? Cursor { get; set; } = default!;

	/// <summary>
	/// <para>An optional object to be used with the request. If specified, <c>options</c> must not be <c>null</c>.</para>
	/// </summary>
	[JsonPropertyName("options")]
	public Entity.CashflowReportGetRequestOptions? Options { get; set; } = default!;

}
