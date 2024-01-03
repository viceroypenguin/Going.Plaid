namespace Going.Plaid.Entity;

/// <summary>
/// <para>Result summary object specifying how the <c>name</c> field matched.</para>
/// </summary>
public record KYCCheckNameSummary
{
	/// <summary>
	/// <para>An enum indicating the match type between data provided by user and data checked against an external data source.</para>
	/// </summary>
	[JsonPropertyName("summary")]
	public Entity.MatchSummaryCode Summary { get; init; } = default!;

}
