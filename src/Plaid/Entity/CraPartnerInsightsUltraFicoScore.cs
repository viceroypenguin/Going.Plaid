namespace Going.Plaid.Entity;

/// <summary>
/// <para>The calculated UltraFICO score.</para>
/// </summary>
public record CraPartnerInsightsUltraFicoScore
{
	/// <summary>
	/// <para>The version of the UltraFICO score.</para>
	/// </summary>
	[JsonPropertyName("ultrafico_score_version")]
	public Entity.CraPartnerInsightsUltraFicoScoreVersion UltraficoScoreVersion { get; init; } = default!;

	/// <summary>
	/// <para>Numeric value of the UltraFICO score.</para>
	/// </summary>
	[JsonPropertyName("score")]
	public int Score { get; init; } = default!;

	/// <summary>
	/// <para>The first reason code associated with the score.</para>
	/// </summary>
	[JsonPropertyName("reason_code_1")]
	public string? ReasonCode1 { get; init; } = default!;

	/// <summary>
	/// <para>The second reason code associated with the score.</para>
	/// </summary>
	[JsonPropertyName("reason_code_2")]
	public string? ReasonCode2 { get; init; } = default!;

	/// <summary>
	/// <para>The third reason code associated with the score.</para>
	/// </summary>
	[JsonPropertyName("reason_code_3")]
	public string? ReasonCode3 { get; init; } = default!;

	/// <summary>
	/// <para>The fourth reason code associated with the score.</para>
	/// </summary>
	[JsonPropertyName("reason_code_4")]
	public string? ReasonCode4 { get; init; } = default!;

	/// <summary>
	/// <para>Whether inquiries adversely affected the score but were not represented in one of the four reason codes. Sometimes referred to as the FACTA Flag.</para>
	/// </summary>
	[JsonPropertyName("did_inquiries_adversely_affect_score")]
	public bool? DidInquiriesAdverselyAffectScore { get; init; } = default!;

}
