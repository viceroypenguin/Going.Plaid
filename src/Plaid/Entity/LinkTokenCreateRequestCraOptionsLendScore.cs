namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for use with the CRA LendScore product.</para>
/// </summary>
public class LinkTokenCreateRequestCraOptionsLendScore
{
	/// <summary>
	/// <para>The version of the LendScore</para>
	/// </summary>
	[JsonPropertyName("lend_score_version")]
	public Entity.PlaidLendScoreVersion? LendScoreVersion { get; set; } = default!;

}
