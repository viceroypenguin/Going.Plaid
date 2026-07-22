namespace Going.Plaid.Entity;

/// <summary>
/// <para>Deprecated. This field is no longer accepted for new clients (created on or after 2026-07-01). New clients should specify required products when creating the Consumer Report. Existing integrations may continue to pass <c>options</c>.</para>
/// </summary>
public class CraCheckReportCashflowInsightsGetOptions
{
	/// <summary>
	/// <para>The version of cashflow attributes. Required if using Cash Flow Insights.</para>
	/// </summary>
	[JsonPropertyName("attributes_version")]
	public Entity.CashflowAttributesVersion? AttributesVersion { get; set; } = default!;

}
