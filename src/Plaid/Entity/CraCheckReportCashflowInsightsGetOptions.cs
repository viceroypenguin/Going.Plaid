namespace Going.Plaid.Entity;

/// <summary>
/// <para>Defines configuration options to generate Cashflow Insights</para>
/// </summary>
public class CraCheckReportCashflowInsightsGetOptions
{
	/// <summary>
	/// <para>The version of the Plaid Check score to return</para>
	/// </summary>
	[JsonPropertyName("plaid_check_score_version")]
	public string? PlaidCheckScoreVersion { get; set; } = default!;

	/// <summary>
	/// <para>The versions of cashflow attributes</para>
	/// </summary>
	[JsonPropertyName("attributes_version")]
	public Entity.CashflowAttributesVersion? AttributesVersion { get; set; } = default!;

}
