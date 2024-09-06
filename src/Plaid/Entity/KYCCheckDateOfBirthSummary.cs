namespace Going.Plaid.Entity;

/// <summary>
/// <para>Result summary object specifying how the <c>date_of_birth</c> field matched.</para>
/// </summary>
public record KYCCheckDateOfBirthSummary
{
	/// <summary>
	/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
	/// </summary>
	[JsonPropertyName("summary")]
	public Entity.MatchSummaryCode Summary { get; init; } = default!;

	/// <summary>
	/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
	/// </summary>
	[JsonPropertyName("day")]
	public Entity.MatchSummaryCode? Day { get; init; } = default!;

	/// <summary>
	/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
	/// </summary>
	[JsonPropertyName("month")]
	public Entity.MatchSummaryCode? Month { get; init; } = default!;

	/// <summary>
	/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
	/// </summary>
	[JsonPropertyName("year")]
	public Entity.MatchSummaryCode? Year { get; init; } = default!;

}
