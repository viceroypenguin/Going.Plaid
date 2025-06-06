namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for use with the Cashflow Insights product.</para>
/// </summary>
public class LinkTokenCreateRequestCraOptionsCashflowInsights
{
	/// <summary>
	/// <para>The version of the Plaid Check Score</para>
	/// </summary>
	[JsonPropertyName("plaid_check_score_version")]
	public Entity.PlaidCheckScoreVersion? PlaidCheckScoreVersion { get; set; } = default!;

	/// <summary>
	/// <para>The version of cashflow attributes</para>
	/// </summary>
	[JsonPropertyName("attributes_version")]
	public Entity.CashflowAttributesVersion? AttributesVersion { get; set; } = default!;

}
