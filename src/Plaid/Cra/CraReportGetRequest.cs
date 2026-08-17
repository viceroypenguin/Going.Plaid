namespace Going.Plaid.Cra;

/// <summary>
/// <para>CraReportGetRequest defines the request schema for <c>/cra/report/get</c>.</para>
/// </summary>
public partial class CraReportGetRequest : RequestBase
{
	/// <summary>
	/// <para>A unique user identifier, created by <c>/user/create</c>. Integrations that began using <c>/user/create</c> after December 10, 2025 use this field to identify a user instead of the <c>user_token</c>. For more details, see <a href="https://plaid.com/docs/api/users/user-apis">New User APIs</a>.</para>
	/// </summary>
	[JsonPropertyName("user_id")]
	public string UserId { get; set; } = default!;

	/// <summary>
	/// <para>The requested products and their versions, e.g. <c>[{"product":"cra_qualify","version":"V1"}]</c>.</para>
	/// </summary>
	[JsonPropertyName("products")]
	public IReadOnlyList<Entity.CraReportGetRequestProduct> Products { get; set; } = default!;

	/// <summary>
	/// <para>Determines whose items are used. <c>PLAID_NETWORK</c> (default) uses the Plaid Network view of the user's profile. <c>CLIENT_USER</c> uses only the items linked by this client.</para>
	/// </summary>
	[JsonPropertyName("scope")]
	public Entity.CraReportScope? Scope { get; set; } = default!;

	/// <summary>
	/// <para>The stage in the lending lifecycle for which the report is being retrieved.</para>
	/// </summary>
	[JsonPropertyName("decision_stage")]
	public Entity.CraReportDecisionStage DecisionStage { get; set; } = default!;

	/// <summary>
	/// <para>Describes the reason you are generating a Consumer Report for this user. When calling <c>/link/token/create</c>, this field is required when using Plaid Check (CRA) products; invalid if not using Plaid Check (CRA) products.</para>
	/// </summary>
	[JsonPropertyName("consumer_report_permissible_purpose")]
	public Entity.ConsumerReportPermissiblePurpose ConsumerReportPermissiblePurpose { get; set; } = default!;

	/// <summary>
	/// <para>A unique ID identifying a CRA report. Like all Plaid identifiers, this ID is case sensitive. When provided, that specific report is returned; when omitted, the most recent report matching the request is returned.</para>
	/// </summary>
	[JsonPropertyName("report_id")]
	public string? ReportId { get; set; } = default!;

}
