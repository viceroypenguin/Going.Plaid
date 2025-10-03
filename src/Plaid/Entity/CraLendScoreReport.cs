namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains data for the CRA Lend Score Report.</para>
/// </summary>
public record CraLendScoreReport
{
	/// <summary>
	/// <para>The unique identifier associated with the Network Attributes report object.</para>
	/// </summary>
	[JsonPropertyName("report_id")]
	public string ReportId { get; init; } = default!;

	/// <summary>
	/// <para>The time when the Network Attributes Report was generated.</para>
	/// </summary>
	[JsonPropertyName("generated_time")]
	public DateTimeOffset GeneratedTime { get; init; } = default!;

	/// <summary>
	/// <para>The results of the Lend Score</para>
	/// </summary>
	[JsonPropertyName("lend_score")]
	public Entity.LendScore? LendScore { get; init; } = default!;

}
