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

	/// <summary>
	/// <para>If the Income Insights generation was successful but a subset of data could not be retrieved, this array will contain information about the errors causing information to be missing</para>
	/// </summary>
	[JsonPropertyName("warnings")]
	public IReadOnlyList<Entity.CraReportWarning>? Warnings { get; init; } = default!;

}
