namespace Going.Plaid.Entity;

/// <summary>
/// <para>A recorded reduction in the impact of an issue.</para>
/// </summary>
public record BetaIssuesV1IssueResolutionEvent
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("resolution_time")]
	public DateTimeOffset ResolutionTime { get; init; } = default!;

	/// <summary>
	/// <para>How an issue was considered resolved. <c>MANUAL_RESOLUTION</c> indicates Plaid's engineering team has reviewed the issue and mitigated its impact. Issues that are manually resolved may still have a small number of occurrences. <c>AUTOMATED_RESOLUTION</c> indicates the error has not recently occurred and was automatically closed.</para>
	/// </summary>
	[JsonPropertyName("type")]
	public Entity.BetaIssuesV1IssueResolutionType Type { get; init; } = default!;

}
