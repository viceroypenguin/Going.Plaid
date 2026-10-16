namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies the report parameters for Plaid Check products, mirroring the parameters accepted on <c>/cra/report/create</c>.</para>
/// </summary>
public class LinkTokenCreateRequestCraReportParameter
{
	/// <summary>
	/// <para>Determines whose Items are used to generate the report. Only <c>CLIENT_USER</c> is supported on <c>/link/token/create</c>; the report is generated from the Items the user links through your application. To generate a report from the user's Plaid Network profile, use <c>/cra/report/create</c> or <c>/cra/report/get</c> with a <c>scope</c> of <c>PLAID_NETWORK</c>.</para>
	/// </summary>
	[JsonPropertyName("scope")]
	public Entity.CraReportScope Scope { get; set; } = default!;

	/// <summary>
	/// 
	/// </summary>
	[JsonPropertyName("decision_stage")]
	public Entity.CraReportDecisionStage DecisionStage { get; set; } = default!;

	/// <summary>
	/// <para>Client-generated identifier, which can be used by lenders to track loan applications.</para>
	/// </summary>
	[JsonPropertyName("client_report_id")]
	public string? ClientReportId { get; set; } = default!;

	/// <summary>
	/// <para>The number of days of history to include in Plaid Check products. Maximum is 731. If a value lower than 180 is provided, a minimum of 180 days of history will be requested.</para>
	/// </summary>
	[JsonPropertyName("days_requested")]
	public int? DaysRequested { get; set; } = default!;

	/// <summary>
	/// <para>The minimum number of days of data required for the report to be successfully generated.</para>
	/// </summary>
	[JsonPropertyName("days_required")]
	public int? DaysRequired { get; set; } = default!;

	/// <summary>
	/// <para>Indicates that investment data should be extracted from the linked account(s).</para>
	/// </summary>
	[JsonPropertyName("include_investments")]
	public bool? IncludeInvestments { get; set; } = default!;

	/// <summary>
	/// <para>Indicates that identity match results should be included for all products in the report that contain identity information. Defaults to <c>false</c>.</para>
	/// </summary>
	[JsonPropertyName("include_identity_match")]
	public bool? IncludeIdentityMatch { get; set; } = default!;

	/// <summary>
	/// <para>The Plaid Check products, versions, and options to generate for the report.</para>
	/// </summary>
	[JsonPropertyName("products")]
	public IReadOnlyList<Entity.CraReportProduct>? Products { get; set; } = default!;

}
