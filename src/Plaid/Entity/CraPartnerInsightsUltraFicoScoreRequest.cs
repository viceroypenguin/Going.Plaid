namespace Going.Plaid.Entity;

/// <summary>
/// <para>Configuration required to generate a single UltraFICO® score.</para>
/// </summary>
public class CraPartnerInsightsUltraFicoScoreRequest
{
	/// <summary>
	/// <para>The version of the UltraFICO® score.</para>
	/// </summary>
	[JsonPropertyName("ultrafico_score_version")]
	public Entity.CraPartnerInsightsUltraFicoScoreVersion UltraficoScoreVersion { get; set; } = default!;

	/// <summary>
	/// <para>FICO identifier for a particular scoring request. Should only be provided by FICO as part of the FICO-led flow.</para>
	/// </summary>
	[JsonPropertyName("fico_scoring_request_id")]
	public string? FicoScoringRequestId { get; set; } = default!;

	/// <summary>
	/// <para>Client-generated identifier that can be used to correlate scoring requests with their scoring results.</para>
	/// </summary>
	[JsonPropertyName("request_correlation_id")]
	public string? RequestCorrelationId { get; set; } = default!;

	/// <summary>
	/// <para>Details about the base FICO score associated with an UltraFICO® scoring request.</para>
	/// </summary>
	[JsonPropertyName("base_fico_score")]
	public Entity.CraPartnerInsightsBaseFicoScore BaseFicoScore { get; set; } = default!;

}
