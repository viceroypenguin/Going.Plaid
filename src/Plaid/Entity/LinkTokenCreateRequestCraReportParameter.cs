namespace Going.Plaid.Entity;

/// <summary>
/// <para>Specifies the report parameters for Plaid Check products, mirroring the parameters accepted on <c>/cra/report/create</c>.</para>
/// </summary>
public class LinkTokenCreateRequestCraReportParameter
{
	/// <summary>
	/// <para>Determines whose items are used. <c>PLAID_NETWORK</c> (default) uses the Plaid Network view of the user's profile. <c>CLIENT_USER</c> uses only the items linked by this client.</para>
	/// </summary>
	[JsonPropertyName("scope")]
	public Entity.CraReportScope? Scope { get; set; } = default!;

	/// <summary>
	/// <para>The stage in the lending lifecycle that the report is for.</para>
	/// </summary>
	[JsonPropertyName("decision_stage")]
	public Entity.CraReportDecisionStage? DecisionStage { get; set; } = default!;

	/// <summary>
	/// <para>Client-generated identifier, which can be used by lenders to track loan applications.</para>
	/// </summary>
	[JsonPropertyName("client_report_id")]
	public string? ClientReportId { get; set; } = default!;

	/// <summary>
	/// <para>The number of days of history to include in Plaid Check products. Maximum is 731; minimum is 180. If a value lower than 180 is provided, a minimum of 180 days of history will be requested.</para>
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
	/// <para>The Plaid Check products, versions, and options to generate for the report.</para>
	/// </summary>
	[JsonPropertyName("products")]
	public IReadOnlyList<Entity.CraReportProduct>? Products { get; set; } = default!;

}
