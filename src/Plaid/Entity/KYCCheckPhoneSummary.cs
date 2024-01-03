namespace Going.Plaid.Entity;

/// <summary>
/// <para>Result summary object specifying how the <c>phone</c> field matched.</para>
/// </summary>
public record KYCCheckPhoneSummary
{
	/// <summary>
	/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
	/// </summary>
	[JsonPropertyName("summary")]
	public Entity.MatchSummaryCode Summary { get; init; } = default!;

	/// <summary>
	/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
	/// </summary>
	[JsonPropertyName("area_code")]
	public Entity.MatchSummaryCode AreaCode { get; init; } = default!;

}
