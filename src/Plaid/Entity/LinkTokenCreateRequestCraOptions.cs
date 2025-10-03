namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies options for initializing Link for use with Plaid Check products</para>
/// </summary>
public class LinkTokenCreateRequestCraOptions
{
	/// <summary>
	/// <para>The number of days of history to include in Plaid Check products. Maximum is 731; minimum is 180. If a value lower than 180 is provided, a minimum of 180 days of history will be requested.</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int DaysRequested { get; set; } = default!;

	/// <summary>
	/// <para>The minimum number of days of data required for the report to be successfully generated.</para>
	/// </summary>
	[JsonPropertyName("days_required")]
	public int? DaysRequired { get; set; } = default!;

	/// <summary>
	/// <para>Client-generated identifier, which can be used by lenders to track loan applications.</para>
	/// </summary>
	[JsonPropertyName("client_report_id")]
	public string? ClientReportId { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for initializing Link for use with the Credit Partner Insights product.</para>
	/// </summary>
	[JsonPropertyName("partner_insights")]
	public Entity.LinkTokenCreateRequestCraOptionsPartnerInsights? PartnerInsights { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for initializing Link for use with the Base Report product, specifically the <c>client_report_id</c>.</para>
	/// </summary>
	[JsonPropertyName("base_report")]
	public Entity.LinkTokenCreateRequestCraOptionsBaseReport? BaseReport { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for initializing Link for use with the Cashflow Insights product.</para>
	/// </summary>
	[JsonPropertyName("cashflow_insights")]
	public Entity.LinkTokenCreateRequestCraOptionsCashflowInsights? CashflowInsights { get; set; } = default!;

	/// <summary>
	/// <para>Specifies options for initializing Link for use with the CRA Lend Score product.</para>
	/// </summary>
	[JsonPropertyName("lend_score")]
	public Entity.LinkTokenCreateRequestCraOptionsLendScore? LendScore { get; set; } = default!;

	/// <summary>
	/// <para>Indicates that investment data should be extracted from the linked account(s).</para>
	/// </summary>
	[JsonPropertyName("include_investments")]
	public bool? IncludeInvestments { get; set; } = default!;

}
