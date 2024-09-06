namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for use with Plaid Check products</para>
/// </summary>
public class LinkTokenCreateRequestCraOptions
{
	/// <summary>
	/// <para>The number of days of history to include in Plaid Check products. If requesting Income Insights, a minimum of 90 days is recommended in order to receive both historical and forecasted income.</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int DaysRequested { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for initializing Link for use with the Credit Partner Insights product.</para>
	/// </summary>
	[JsonPropertyName("partner_insights")]
	public Entity.LinkTokenCreateRequestCraOptionsPartnerInsights? PartnerInsights { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for initializing Link for use with the Base Report product.</para>
	/// </summary>
	[JsonPropertyName("base_report")]
	public Entity.LinkTokenCreateRequestCraOptionsBaseReport? BaseReport { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for initializing Link for use with the Cashflow Insights product.</para>
	/// </summary>
	[JsonPropertyName("cashflow_insights")]
	public Entity.LinkTokenCreateRequestCraOptionsCashflowInsights? CashflowInsights { get; set; } = default!;

}
