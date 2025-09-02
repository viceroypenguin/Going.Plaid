namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for use with the Plaid Credit Score product.</para>
/// </summary>
public class LinkTokenCreateRequestCraOptionsPlaidCreditScore
{
	/// <summary>
	/// <para>The version of the Plaid Credit Score</para>
	/// </summary>
	[JsonPropertyName("plaid_credit_score_version")]
	public Entity.PlaidCheckScoreVersion? PlaidCreditScoreVersion { get; set; } = default!;

}
