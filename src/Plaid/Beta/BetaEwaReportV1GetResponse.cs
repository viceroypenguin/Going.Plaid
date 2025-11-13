namespace Going.Plaid.Beta;

/// <summary>
/// <para>BetaEwaReportV1GetResponse defines the response schema for <c>/beta/ewa_report/v1/get</c></para>
/// </summary>
public record BetaEwaReportV1GetResponse : ResponseBase
{
	/// <summary>
	/// <para>Unique identifier for the generated EWA score group.</para>
	/// </summary>
	[JsonPropertyName("ewa_report_id")]
	public string? EwaReportId { get; init; } = default!;

	/// <summary>
	/// <para>The date and time when <c>ewa_scores</c> was generated, in ISO 8601 format (e.g. "2018-04-12T03:32:11Z").</para>
	/// </summary>
	[JsonPropertyName("generation_time")]
	public DateTimeOffset? GenerationTime { get; init; } = default!;

	/// <summary>
	/// <para>A list of earned wage access (EWA) scoring entries that map potential advance amounts to repayment likelihood scores. The predefined advance amount ranges are <c>[0, 25]</c>, <c>[25, 50]</c>, <c>[50, 100]</c>, <c>[100, 200]</c>, <c>[200, 300]</c>, <c>[300, 400]</c>, and <c>[400, 500]</c>.</para>
	/// </summary>
	[JsonPropertyName("ewa_scores")]
	public IReadOnlyList<Entity.EwaScore>? EwaScores { get; init; } = default!;

}
