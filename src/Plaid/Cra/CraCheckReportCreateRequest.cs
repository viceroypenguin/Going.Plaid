namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraCheckReportCreateRequest defines the request schema for <c>/cra/check_report/create</c>.</para>
/// </summary>
public partial class CraCheckReportCreateRequest : RequestBase
{
	/// <summary>
	/// <para>The user token associated with the User data is being requested for.</para>
	/// </summary>
	[JsonPropertyName("user_token")]
	public string UserToken { get; set; } = default!;

	/// <summary>
	/// <para>The destination URL to which webhooks will be sent</para>
	/// </summary>
	[JsonPropertyName("webhook")]
	public string Webhook { get; set; } = default!;

	/// <summary>
	/// <para>The number of days of data to request for the report. Default value is 365; maximum is 731; minimum is 180. If a value lower than 180 is provided, a minimum of 180 days of history will be requested.</para>
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
	/// <para>Specifies a list of products that will be eagerly generated when creating the report (in addition to the Base Report, which is always eagerly generated). These products will be made available before a success webhook is sent. Use this option to minimize response latency for product <c>/get</c> endpoints. Note that specifying <c>cra_partner_insights</c> in this field will trigger a billable event. Other products are not billed until the respective reports are fetched via product-specific <c>/get</c> endpoints.</para>
	/// </summary>
	[JsonPropertyName("products")]
	public IReadOnlyList<Entity.Products>? Products { get; set; } = default!;

	/// <summary>
	/// <para>Defines configuration options to generate a Base Report</para>
	/// </summary>
	[JsonPropertyName("base_report")]
	public Entity.CraCheckReportCreateBaseReportOptions? BaseReport { get; set; } = default!;

	/// <summary>
	/// <para>Defines configuration options to generate Cashflow Insights</para>
	/// </summary>
	[JsonPropertyName("cashflow_insights")]
	public Entity.CraCheckReportCashflowInsightsGetOptions? CashflowInsights { get; set; } = default!;

	/// <summary>
	/// <para>Defines configuration to generate Partner Insights.</para>
	/// </summary>
	[JsonPropertyName("partner_insights")]
	public Entity.CraCheckReportCreatePartnerInsightsOptions? PartnerInsights { get; set; } = default!;

	/// <summary>
	/// <para>Describes the reason you are generating a Consumer Report for this user.</para>
	/// </summary>
	[JsonPropertyName("consumer_report_permissible_purpose")]
	public Entity.ConsumerReportPermissiblePurpose ConsumerReportPermissiblePurpose { get; set; } = default!;

}
