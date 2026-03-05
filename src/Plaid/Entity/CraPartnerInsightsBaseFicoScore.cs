namespace Going.Plaid.Entity;

/// <summary>
/// <para>Details about the base FICO score associated with an UltraFICO scoring request.</para>
/// </summary>
public class CraPartnerInsightsBaseFicoScore
{
	/// <summary>
	/// <para>The credit bureau that provided the base FICO score.</para>
	/// </summary>
	[JsonPropertyName("bureau")]
	public Entity.CraPartnerInsightsBureau Bureau { get; set; } = default!;

	/// <summary>
	/// <para>Numeric value of the base FICO score.</para>
	/// </summary>
	[JsonPropertyName("score")]
	public int Score { get; set; } = default!;

	/// <summary>
	/// <para>The first reason code associated with the score.</para>
	/// </summary>
	[JsonPropertyName("reason_code_1")]
	public string? ReasonCode1 { get; set; } = default!;

	/// <summary>
	/// <para>The second reason code associated with the score.</para>
	/// </summary>
	[JsonPropertyName("reason_code_2")]
	public string? ReasonCode2 { get; set; } = default!;

	/// <summary>
	/// <para>The third reason code associated with the score.</para>
	/// </summary>
	[JsonPropertyName("reason_code_3")]
	public string? ReasonCode3 { get; set; } = default!;

	/// <summary>
	/// <para>The fourth reason code associated with the score.</para>
	/// </summary>
	[JsonPropertyName("reason_code_4")]
	public string? ReasonCode4 { get; set; } = default!;

	/// <summary>
	/// <para>Whether inquiries adversely affected this score but were not represented in one of the four reason codes. Sometimes referred to as the FACTA Flag.</para>
	/// </summary>
	[JsonPropertyName("did_inquiries_adversely_affect_score")]
	public bool? DidInquiriesAdverselyAffectScore { get; set; } = default!;

	/// <summary>
	/// <para>The version of the base FICO score model.</para>
	/// </summary>
	[JsonPropertyName("base_fico_score_version")]
	public Entity.CraPartnerInsightsBaseFicoScoreVersion BaseFicoScoreVersion { get; set; } = default!;

}
