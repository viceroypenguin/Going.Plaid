namespace Going.Plaid.Entity;

/// <summary>
/// <para>Defines configuration options to generate the LendScore</para>
/// </summary>
public class CraCheckReportLendScoreGetOptions
{
	/// <summary>
	/// <para>The version of the LendScore</para>
	/// </summary>
	[JsonPropertyName("lend_score_version")]
	public Entity.PlaidLendScoreVersion? LendScoreVersion { get; set; } = default!;

}
