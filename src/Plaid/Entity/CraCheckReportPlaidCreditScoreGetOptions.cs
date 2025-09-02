namespace Going.Plaid.Entity;

/// <summary>
/// <para>Defines configuration options to generate the Plaid Credit Score</para>
/// </summary>
public class CraCheckReportPlaidCreditScoreGetOptions
{
	/// <summary>
	/// <para>The version of the Plaid Credit Score</para>
	/// </summary>
	[JsonPropertyName("plaid_credit_score_version")]
	public Entity.PlaidCheckScoreVersion? PlaidCreditScoreVersion { get; set; } = default!;

}
