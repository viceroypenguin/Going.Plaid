namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraCheckReportIncomeInsightsGetResponse defines the response schema for <c>/cra/check_report/income_insights/get</c>.</para>
/// </summary>
public record CraCheckReportIncomeInsightsGetResponse : ResponseBase
{
	/// <summary>
	/// <para>The Check Income Insights Report for an end user.</para>
	/// </summary>
	[JsonPropertyName("report")]
	public Entity.CraIncomeInsights? Report { get; init; } = default!;

}
