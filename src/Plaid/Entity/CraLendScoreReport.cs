namespace Going.Plaid.Entity;

/// <summary>
/// <para>Contains data for the CRA LendScore Report.</para>
/// </summary>
public record CraLendScoreReport
{
	/// <summary>
	/// <para>The unique identifier associated with the report object.</para>
	/// </summary>
	[JsonPropertyName("report_id")]
	public string ReportId { get; init; } = default!;

	/// <summary>
	/// <para>The time when the report was generated.</para>
	/// </summary>
	[JsonPropertyName("generated_time")]
	public DateTimeOffset GeneratedTime { get; init; } = default!;

	/// <summary>
	/// <para>The results of the LendScore</para>
	/// </summary>
	[JsonPropertyName("lend_score")]
	public Entity.LendScore? LendScore { get; init; } = default!;

}
