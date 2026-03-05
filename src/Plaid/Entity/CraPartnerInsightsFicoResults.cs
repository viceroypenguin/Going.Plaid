namespace Going.Plaid.Entity;

/// <summary>
/// <para>The calculated UltraFICO scores returned as part of the Partner Insights report.</para>
/// </summary>
public record CraPartnerInsightsFicoResults
{
	/// <summary>
	/// <para>Client-generated identifier that uniquely identifies the FICO Application across FICO systems.</para>
	/// </summary>
	[JsonPropertyName("lender_application_id")]
	public string LenderApplicationId { get; init; } = default!;

	/// <summary>
	/// <para>UltraFICO scoring results, one per provided base FICO score request.</para>
	/// </summary>
	[JsonPropertyName("ultrafico_score_results")]
	public IReadOnlyList<Entity.CraPartnerInsightsUltraFicoScoreResult> UltraficoScoreResults { get; init; } = default!;

}
