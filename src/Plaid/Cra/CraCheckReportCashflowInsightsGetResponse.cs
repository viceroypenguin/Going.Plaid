namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraCheckReportCashflowInsightsGetResponse defines the response schema for <c>/cra/check_report/cashflow_insights/get</c>.</para>
/// </summary>
public record CraCheckReportCashflowInsightsGetResponse : ResponseBase
{
	/// <summary>
	/// <para>Contains data for the CRA Cashflow Insights Report.</para>
	/// </summary>
	[JsonPropertyName("report")]
	public Entity.CraCashflowInsightsReport Report { get; init; } = default!;

}
