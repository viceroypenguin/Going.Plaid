namespace Going.Plaid.Entity;

/// <summary>
/// <para>Defines configuration options to generate the Lend Score</para>
/// </summary>
public class CraCheckReportLendScoreGetOptions
{
	/// <summary>
	/// <para>The version of the Lend Score</para>
	/// </summary>
	[JsonPropertyName("lend_score_version")]
	public Entity.PlaidCheckScoreVersion? LendScoreVersion { get; set; } = default!;

}
