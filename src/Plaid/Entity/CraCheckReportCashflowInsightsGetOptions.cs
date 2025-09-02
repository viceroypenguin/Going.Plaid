namespace Going.Plaid.Entity;

/// <summary>
/// <para>Defines configuration options to generate Cashflow Insights</para>
/// </summary>
public class CraCheckReportCashflowInsightsGetOptions
{
	/// <summary>
	/// <para>The version of the Plaid Credit Score</para>
	/// </summary>
	[JsonPropertyName("plaid_check_score_version")]
	public Entity.PlaidCheckScoreVersion? PlaidCheckScoreVersion { get; set; } = default!;

	/// <summary>
	/// <para>The version of cashflow attributes</para>
	/// </summary>
	[JsonPropertyName("attributes_version")]
	public Entity.CashflowAttributesVersion? AttributesVersion { get; set; } = default!;

}
