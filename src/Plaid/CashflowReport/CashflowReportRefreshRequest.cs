namespace Going.Plaid.CashflowReport;

/// <summary>
/// <para>CashflowReportRefreshRequest defines the request schema for <c>/cashflow_report/refresh</c></para>
/// </summary>
public partial class CashflowReportRefreshRequest : RequestBase
{
	/// <summary>
	/// <para>Number of days to retrieve transactions data for (1 to 730)</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int DaysRequested { get; set; } = default!;

}
