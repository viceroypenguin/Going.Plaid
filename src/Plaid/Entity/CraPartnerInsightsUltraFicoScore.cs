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
	/// <para>Negative reason codes associated with the score (reasons the score moved downward), in priority order. May contain up to 4 items.</para>
	/// </summary>
	[JsonPropertyName("negative_reason_codes")]
	public IReadOnlyList<string>? NegativeReasonCodes { get; init; } = default!;

	/// <summary>
	/// <para>Positive reason codes associated with the score (reasons the score moved upward), in priority order. May contain up to 4 items.</para>
	/// </summary>
	[JsonPropertyName("positive_reason_codes")]
	public IReadOnlyList<string>? PositiveReasonCodes { get; init; } = default!;

	/// <summary>
	/// <para>Deprecated. Use <c>negative_reason_codes</c> instead. The first reason code associated with the score.</para>
	/// </summary>
	[JsonPropertyName("reason_code_1")]
	[Obsolete]
	public string? ReasonCode1 { get; init; } = default!;

	/// <summary>
	/// <para>Deprecated. Use <c>negative_reason_codes</c> instead. The second reason code associated with the score.</para>
	/// </summary>
	[JsonPropertyName("reason_code_2")]
	[Obsolete]
	public string? ReasonCode2 { get; init; } = default!;

	/// <summary>
	/// <para>Deprecated. Use <c>negative_reason_codes</c> instead. The third reason code associated with the score.</para>
	/// </summary>
	[JsonPropertyName("reason_code_3")]
	[Obsolete]
	public string? ReasonCode3 { get; init; } = default!;

	/// <summary>
	/// <para>Deprecated. Use <c>negative_reason_codes</c> instead. The fourth reason code associated with the score.</para>
	/// </summary>
	[JsonPropertyName("reason_code_4")]
	[Obsolete]
	public string? ReasonCode4 { get; init; } = default!;

	/// <summary>
	/// <para>Deprecated. Use <c>positive_reason_codes</c> instead. The first positive reason code associated with the score.</para>
	/// </summary>
	[JsonPropertyName("positive_reason_code_1")]
	[Obsolete]
	public string? PositiveReasonCode1 { get; init; } = default!;

	/// <summary>
	/// <para>Deprecated. Use <c>positive_reason_codes</c> instead. The second positive reason code associated with the score.</para>
	/// </summary>
	[JsonPropertyName("positive_reason_code_2")]
	[Obsolete]
	public string? PositiveReasonCode2 { get; init; } = default!;

	/// <summary>
	/// <para>Deprecated. Use <c>positive_reason_codes</c> instead. The third positive reason code associated with the score.</para>
	/// </summary>
	[JsonPropertyName("positive_reason_code_3")]
	[Obsolete]
	public string? PositiveReasonCode3 { get; init; } = default!;

	/// <summary>
	/// <para>Deprecated. Use <c>positive_reason_codes</c> instead. The fourth positive reason code associated with the score.</para>
	/// </summary>
	[JsonPropertyName("positive_reason_code_4")]
	[Obsolete]
	public string? PositiveReasonCode4 { get; init; } = default!;

	/// <summary>
	/// <para>Whether inquiries adversely affected the score but were not represented in one of the four reason codes. Sometimes referred to as the FACTA Flag.</para>
	/// </summary>
	[JsonPropertyName("did_inquiries_adversely_affect_score")]
	public bool? DidInquiriesAdverselyAffectScore { get; init; } = default!;

}
