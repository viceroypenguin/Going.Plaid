namespace Going.Plaid.Entity;

/// <summary>
/// <para>The result of a single UltraFICO score generation request.</para>
/// </summary>
public record CraPartnerInsightsUltraFicoScoreResult
{
	/// <summary>
	/// <para>Client-generated identifier that can be used to correlate between scoring requests and scoring results.</para>
	/// </summary>
	[JsonPropertyName("request_correlation_id")]
	public string? RequestCorrelationId { get; init; } = default!;

	/// <summary>
	/// <para>FICO-provided identifier that uniquely identifies this score generation request.</para>
	/// </summary>
	[JsonPropertyName("fico_scoring_request_id")]
	public string? FicoScoringRequestId { get; init; } = default!;

	/// <summary>
	/// <para>The calculated UltraFICO score.</para>
	/// </summary>
	[JsonPropertyName("ultrafico_score")]
	public Entity.CraPartnerInsightsUltraFicoScore? UltraficoScore { get; init; } = default!;

	/// <summary>
	/// <para>Human-readable description of why the UltraFICO score could not be computed.</para>
	/// </summary>
	[JsonPropertyName("error_reason")]
	public string? ErrorReason { get; init; } = default!;

}
