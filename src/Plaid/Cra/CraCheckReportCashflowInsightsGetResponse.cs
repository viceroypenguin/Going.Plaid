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

	/// <summary>
	/// <para>If the Cashflow Insights generation was successful but a subset of data could not be retrieved, this array will contain information about the errors causing information to be missing</para>
	/// </summary>
	[JsonPropertyName("warnings")]
	public IReadOnlyList<Entity.CraReportWarning>? Warnings { get; init; } = default!;

}
