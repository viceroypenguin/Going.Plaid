namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for use with the CRA Lend Score product.</para>
/// </summary>
public class LinkTokenCreateRequestCraOptionsLendScore
{
	/// <summary>
	/// <para>The version of the Lend Score</para>
	/// </summary>
	[JsonPropertyName("lend_score_version")]
	public Entity.PlaidCheckScoreVersion? LendScoreVersion { get; set; } = default!;

}
