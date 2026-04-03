namespace Going.Plaid.Entity;

/// <summary>
/// <para>Defines configuration options to generate Cashflow Insights</para>
/// </summary>
public class CraCheckReportCashflowInsightsGetOptions
{
	/// <summary>
	/// <para>The version of cashflow attributes. Required if using Cash Flow Insights.</para>
	/// </summary>
	[JsonPropertyName("attributes_version")]
	public Entity.CashflowAttributesVersion? AttributesVersion { get; set; } = default!;

}
