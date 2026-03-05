namespace Going.Plaid.Entity;

/// <summary>
/// <para>Configurations for FICO products used in the Partner Insights flow.</para>
/// </summary>
public class CraPartnerInsightsFicoInput
{
	/// <summary>
	/// <para>ID provided by FICO that uniquely identifies the lender. Required for UltraFICO score generation. Sometimes referred to as Lender Org ID.</para>
	/// </summary>
	[JsonPropertyName("fico_lender_id")]
	public string FicoLenderId { get; set; } = default!;

	/// <summary>
	/// <para>Client-generated identifier that uniquely identifies the FICO Application ID across FICO systems.</para>
	/// </summary>
	[JsonPropertyName("lender_application_id")]
	public string LenderApplicationId { get; set; } = default!;

	/// <summary>
	/// <para>A list of UltraFICO scoring requests. Each request contains all configuration required to generate an UltraFICO score.</para>
	/// </summary>
	[JsonPropertyName("ultrafico_score_requests")]
	public IReadOnlyList<Entity.CraPartnerInsightsUltraFicoScoreRequest> UltraficoScoreRequests { get; set; } = default!;

}
