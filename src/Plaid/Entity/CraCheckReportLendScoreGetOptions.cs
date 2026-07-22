namespace Going.Plaid.Entity;

/// <summary>
/// <para>Deprecated. This field is no longer accepted for new clients (created on or after 2026-07-01). New clients should specify required products when creating the Consumer Report. Existing integrations may continue to pass <c>options</c>.</para>
/// </summary>
public class CraCheckReportLendScoreGetOptions
{
	/// <summary>
	/// <para>The version of the LendScore to use. Required if using LendScore.</para>
	/// </summary>
	[JsonPropertyName("lend_score_version")]
	public Entity.PlaidLendScoreVersion? LendScoreVersion { get; set; } = default!;

}
